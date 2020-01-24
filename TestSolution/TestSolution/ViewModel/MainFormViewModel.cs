using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcquisition;
using Parser;
using TestSolution.Annotations;
using TestSolution.Model;

namespace TestSolution.ViewModel
{
  internal class MainFormViewModel : INotifyPropertyChanged
  {
    private readonly MainFormModel model;
    private readonly ResponseParser parser = new ResponseParser();
    private readonly DataReader dataReader;
    private readonly Control control;

    public MainFormViewModel(MainFormModel model, Control control)
    {
      this.control = control;
      this.model = model;
      DateTime = DateTime.Now;
      model.DataSource = new BindingList<ResultItemModel>();
      dataReader = new DataReader(model.URL);
    }

    public DateTime DateTime
    {
      get { return model.DateTime; }
      set
      {
        if (model.DateTime != value)
        {
          model.DateTime = value;
          model.Timestamp = new DateTimeOffset(value).ToUnixTimeSeconds();
          OnPropertyChanged(nameof(DateTime));
          OnPropertyChanged(nameof(Timestamp));
        }
      }
    }

    public BindingList<ResultItemModel> DataSource => model.DataSource;

    public string Timestamp => model.Timestamp.ToString();

    public string ErrorMessage => model.ErrorMessage;

    public bool ErrorThrown => !string.IsNullOrEmpty(model.ErrorMessage);

    public bool InProgress
    {
      get { return model.InProgress; }
      set
      {
        if (value != model.InProgress)
        {
          model.InProgress = value;
          OnPropertyChanged(nameof(InProgress));
        }
      }
    }

    public void StartAction()
    {
      InProgress = true;
      var result = dataReader.GetDataAsync(model.Timestamp);
      result.ContinueWith(r => ParserTask(r.Result), TaskContinuationOptions.NotOnFaulted);
      result.ContinueWith(t => HandleException(t.Exception), TaskContinuationOptions.OnlyOnFaulted);
    }

    private void ParserTask(string xml)
    {
      var parserTask = parser.ParseXmlAsync(xml);
      parserTask.ContinueWith(r =>
      {
        this.control.Invoke(new Action(() =>
        {
          DataSource.Clear();

          foreach (var item in r.Result)
          {
            model.DataSource.Add(new ResultItemModel() {Value = item.Key, Count = item.Value});
          }

          model.ErrorMessage = string.Empty;
          InProgress = false;
          OnPropertyChanged(nameof(ErrorMessage));
          OnPropertyChanged(nameof(ErrorThrown));
          OnPropertyChanged(nameof(DataSource));
        }));
      }, TaskContinuationOptions.NotOnFaulted);


      parserTask.ContinueWith(t => { HandleException(t.Exception); }, TaskContinuationOptions.OnlyOnFaulted);
    }

    private void HandleException(Exception ex)
    {
      this.control.Invoke(new Action(() =>
      {
        model.ErrorMessage = $"Error was Thrown:{ex.Message}";
        InProgress = false;
        OnPropertyChanged(nameof(ErrorMessage));
        OnPropertyChanged(nameof(ErrorThrown));
      }));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}