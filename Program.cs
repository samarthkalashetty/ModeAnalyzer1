using System;

class MoodAnalysisException : Exception
{
    public MoodAnalysisException(string message) : base(message)
    {
    }
}

class MoodAnalyzer
{
    private string message;

    public MoodAnalyzer()
    {
        message = "I am in Any Mood";
    }

    public MoodAnalyzer(string message)
    {
        this.message = message;
    }

    public string AnalyseMood()
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
        MoodAnalyzer defaultMoodAnalyzer = new MoodAnalyzer();
        string mood1 = defaultMoodAnalyzer.AnalyseMood();
        Console.WriteLine("Mood 1: " + mood1);

        MoodAnalyzer customMoodAnalyzer = new MoodAnalyzer("Feeling Sad");
        string mood2 = customMoodAnalyzer.AnalyseMood();
        Console.WriteLine("Mood 2: " + mood2);
    }
}
