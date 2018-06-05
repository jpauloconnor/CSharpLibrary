using Microsoft.ML;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System;

namespace _0._99_MachineLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline = new LearningPipeline();

            string dataPath = "iris-data.txt";
            pipeline.Add(new TextLoader<IrisData>(dataPath, separator: ","));

            pipeline.Add(new Dictionarizer("Label"));

            pipeline.Add(new ColumnConcatenator("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"));
            pipeline.Add(new StochasticDualCoordinateAscentClassifier());
            pipeline.Add(new PredictedLabelColumnOriginalValueConverter() { PredictedLabelColumn = "PredictedLabel" });
            var model = pipeline.Train<IrisData, IrisPrediction>();

            var prediction = model.Predict(new IrisData()
            {
                SepalLength = 3.3f,
                SepalWidth = 1.6f,
                PetalLength = 0.2f,
                PetalWidth = 5.1f,
            });

            Console.WriteLine($"Predicted flower type is: {prediction.PredictedLabels}");
        }
    }
}
