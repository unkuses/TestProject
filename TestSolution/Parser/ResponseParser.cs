using Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace Parser
{
  public class ResponseParser : IResponseParser
  {
    async public Task<Dictionary<char, int>> ParseXmlAsync(string xml)
    {
      XmlDocument doc = new XmlDocument();
      doc.LoadXml(xml);
      var node = doc.GetElementsByTagName("record");
      var recordText = node[0].InnerText;
      var result = new Dictionary<char, int>();
      foreach (var c in recordText)
      {
        if (result.ContainsKey(c))
        {
          ++result[c];
        }
        else
        {
          result[c] = 1;
        }
      }

      return result;
    }
  }
}