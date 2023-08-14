using System;

class MoodAnalysisException : Exception
{
    public MoodAnalysisException(string message) : base(message)
    {
    }
}

class MoodAnalyzer
{
    public string AnalyseMood(string message)
    {
        try
        {
            if (message.Contains("Sad"))
            {
                throw new MoodAnalysisException("Mood is sad, but handling the exception.");
            }
            else
            {
                return "HAPPY";
            }
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
            return "HAPPY";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
        string message = "I am in Any Mood";
        string mood = moodAnalyzer.AnalyseMood(message);
        Console.WriteLine("Mood: " + mood);
    }
}
