using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDataReader
    {
      Task<string> GetDataAsync(long timestamp);
    }
}
