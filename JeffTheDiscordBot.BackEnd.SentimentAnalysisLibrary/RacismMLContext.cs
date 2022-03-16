using JeffTheDiscordBot.BackEnd.SentimentAnalysisLibrary.DataStructures;
using Microsoft.ML;

namespace JeffTheDiscordBot.BackEnd.SentimentAnalysisLibrary;

public class RacismMLContext
{
    public void CreateModel()
    {
        var mlContext = new MLContext();
        var dataPath = @"C:\Users\Admin\CodeProjects\JeffTheDiscordBot\JeffTheDiscordBot.BackEnd.SentimentAnalysisLibrary\TweetBLM.csv";
        var trainingData = mlContext.Data.LoadFromTextFile<Comments>(dataPath, separatorChar: ',', hasHeader: true);
        
        IEstimator<ITransformer> dataTransformPipeline = mlContext.Transforms.Text
            .FeaturizeText("Features", "SentimentText");

        IEstimator<ITransformer> trainer = mlContext.BinaryClassification.Trainers
            .AveragedPerceptron(labelColumnName: "Sentiment", featureColumnName: "Features");
        
        IEstimator<ITransformer> trainingPipeline = dataTransformPipeline.Append(trainer);
        
        var model = trainingPipeline.Fit(trainingData);
        


    }
}