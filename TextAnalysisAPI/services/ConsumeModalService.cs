using SampleClassification.Model;
using TextAnalysisAPI.Interfaces;

namespace TextAnalysisAPI.services
{
    public class ConsumeModalService : IConsumeModalService
    {
         public bool ReviewText(string text)
        {
            var input = new ModelInput() 
            {
                Col0 = text
            };

            ModelOutput result = ConsumeModel.Predict(input);
            return result.Prediction == "1" ? true : false;
        }
    }
}