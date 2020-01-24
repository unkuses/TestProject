using System;
using System.Net.Http;
using System.Threading.Tasks;
using Interfaces;

namespace DataAcquisition
{
  public class DataReader : IDataReader
  {
    private readonly string url;
    private readonly Lazy<HttpClient> webClient = new Lazy<HttpClient>();

    public DataReader(string url)
    {
      this.url = url;
    }

    public async Task<string> GetDataAsync(long timestamp)
    {
      var task = webClient.Value.GetAsync($"{url}{timestamp}");
      return await task.Result.Content.ReadAsStringAsync();
    }
  }
}