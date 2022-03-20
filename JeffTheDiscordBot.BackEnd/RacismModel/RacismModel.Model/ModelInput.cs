//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace RacismModel.Model
{
    public class ModelInput
    {
        [ColumnName("label"), LoadColumn(0)]
        public string Label { get; set; }


        [ColumnName("text"), LoadColumn(1)]
        public string Text { get; set; }


    }
}
