using System;
using System.ComponentModel;

namespace TestSolution.Model
{
  internal class MainFormModel
  {
    public string URL = @"https://beacon.nist.gov/rest/record/";

    public bool InProgress = false;

    public string ErrorMessage = string.Empty;
    public DateTime DateTime { get; set; }

    public long Timestamp { get; set; }

    public BindingList<ResultItemModel> DataSource { get; set; }
  }
}
