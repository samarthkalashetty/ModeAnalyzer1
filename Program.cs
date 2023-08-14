using System;

class MoodAnalyser
{
    private string message;

    public MoodAnalyser(string message)
    {
        this.message = message;
    }

    public string AnalyseMood()
    {
        try
        {
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string inputMessage = "I am in Any Mood";

        MoodAnalyser moodAnalyser = new MoodAnalyser(inputMessage);
        string mood = moodAnalyser.AnalyseMood();
        Console.WriteLine("Mood: " + mood);
    }
}