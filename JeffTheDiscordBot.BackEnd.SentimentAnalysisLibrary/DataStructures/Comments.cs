using Microsoft.ML.Data;

namespace JeffTheDiscordBot.BackEnd.SentimentAnalysisLibrary.DataStructures;

public class Comments
{
    [LoadColumn(0)]
    public string Comment { get; set; }
    
    [LoadColumn(1)]
    public bool Label { get; set; }
    
}