using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAcquisition.Tests
{
  [TestClass()]
  public class DataReaderTests
  {
    [TestMethod()]
    public void GetDataTest()
    {
      var reader = new DataReader(@"https://beacon.nist.gov/rest/record/");
      var result = reader.GetDataAsync(1463958840);
      result.Wait();
      Assert.IsFalse(string.IsNullOrEmpty(result.Result));
    }

    [TestMethod]
    public void UnvalidUrlTest()
    {
      var reader = new DataReader(@"?!.");
      var task = reader.GetDataAsync(0);

      try { 
        task.Wait();
      }
      catch (AggregateException) { }

      Assert.IsTrue(task.Exception.InnerExceptions[0] is InvalidOperationException);
    }
  }
}