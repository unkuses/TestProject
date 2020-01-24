using System.Windows.Forms;
using TestSolution.Model;
using TestSolution.ViewModel;

namespace TestSolution
{
  public partial class MainForm : Form
  {
    private readonly MainFormViewModel viewModel;
    public MainForm()
    {
      InitializeComponent();
      viewModel = new MainFormViewModel(new MainFormModel(), this);
      lbTimestamp.DataBindings.Add(nameof(lbTimestamp.Text), viewModel, nameof(viewModel.Timestamp), true, DataSourceUpdateMode.OnPropertyChanged);
      dtmMain.DataBindings.Add(nameof(dtmMain.Value), viewModel, nameof(viewModel.DateTime), true, DataSourceUpdateMode.OnPropertyChanged);
      this.lbError.DataBindings.Add(nameof(lbError.Text), viewModel, nameof(viewModel.ErrorMessage));
      this.lbError.DataBindings.Add(nameof(lbError.Visible), viewModel, nameof(viewModel.ErrorThrown));
      this.progressBar.DataBindings.Add(nameof(progressBar.Visible), viewModel, nameof(viewModel.InProgress));
      this.MainView.DataSource = viewModel.DataSource;
      btnStart.Click += (s, e) => { viewModel.StartAction(); };
    }
  }
}
