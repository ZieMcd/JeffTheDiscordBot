using System.Threading.Tasks;

namespace TextAnalysisAPI.Interfaces
{
    public interface IConsumeModalService
    {
         public Task<string> ReviewTextAsync(string text);
    }
}