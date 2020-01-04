// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.Linq;
using Microsoft.ML;
using Schaad.AccountingML.Model;

namespace Schaad.AccountingML.ConsoleApp
{
    class Program
    {
        private const string XML_FILEPATH = @"D:\Documents\Developer\AccountingData\2019\Claudio Schaad\Data\Transactions.xml";
        private const string DATA_FILEPATH = @"D:\Documents\Developer\AccountingData\2019\Claudio Schaad\Data\data.csv";
        private const string MODEL_FILEPATH = @"D:\Documents\Developer\GitHub\Accounting\Schaad.AccountingML.Model\MLModel.zip";

        static void Main(string[] args)
        {
            // Create new csv
            //CsvCreator.CreateCsv(XML_FILEPATH, DATA_FILEPATH);

            // Train model
            //ModelBuilder.CreateModel(DATA_FILEPATH, MODEL_FILEPATH);

            // Create single instance of sample data from first line of dataset for model input
            var sampleData = CreateSingleDataSample(DATA_FILEPATH);

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Text with predicted Text from sample data...\n\n");
            Console.WriteLine($"BankTransactionText: {sampleData.BankTransactionText}");
            Console.WriteLine($"Value: {sampleData.Value}");
            Console.WriteLine($"ValueDate: {sampleData.ValueDate}");
            Console.WriteLine($"TargetAccountId: {sampleData.TargetAccountId}");
            Console.WriteLine($"\n\nActual Text: {sampleData.Text} \nPredicted Text value {predictionResult.Prediction} \nPredicted Text scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }

        // Change this code to create your own sample data
        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: ';',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false)
                                                                        .First();
            return sampleForPrediction;
        }
        #endregion
    }
}