using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
  public interface IResponseParser
  {
    Task<Dictionary<char, int>> ParseXmlAsync(string xml);
  }
}