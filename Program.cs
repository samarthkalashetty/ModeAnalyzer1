using System;

class MoodAnalyzer
{
    private string message;

    public MoodAnalyzer(string message)
    {
        this.message = message;
    }

    public string AnalyseMood()
    {
        if (message.Contains("Sad"))
        {
            return "SAD";
        }
        else
        {
            return "HAPPY";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
        string mood = moodAnalyzer.AnalyseMood();
        Console.WriteLine("Mood: " + mood);
    }
}
