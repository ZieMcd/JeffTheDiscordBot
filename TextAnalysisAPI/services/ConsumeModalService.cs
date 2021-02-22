using System.Threading.Tasks;
using SampleClassification.Model;
using TextAnalysisAPI.Interfaces;

namespace TextAnalysisAPI.services
{
    public class ConsumeModalService : IConsumeModalService
    {
        public Task<string> ReviewTextAsync(string text)
        {
            var input = new ModelInput() 
            {
                Col0 = text
            };

            ModelOutput result = ConsumeModel.Predict(input);
            
            return Task.FromResult<string> (result.Prediction);
        }
    }
}