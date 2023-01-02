using ModelTrainingApp;
// Add input data
var sampleData = new SentimentModel.ModelInput()
{
    New_reviews = "hotel"
};

// Load model and predict output of sample data
var result = SentimentModel.Predict(sampleData);


String sentiment = null; ;
if (result.PredictedLabel == -1) sentiment = "negative";
if (result.PredictedLabel == 0) sentiment = "neutre";
if (result.PredictedLabel == 1) sentiment = "positive";
Console.WriteLine($"Text: {sampleData.New_reviews}\nSentiment: {sentiment}");
