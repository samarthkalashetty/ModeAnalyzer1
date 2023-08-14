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

    public MoodAnalyzer(string message)
    {
        this.message = message;
    }

    public MoodAnalyzer()
    {
        message = "I am in Happy Mood";
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
        MoodAnalyzer moodAnalyzerWithMessage = new MoodAnalyzer("I am in Happy Mood");
        string mood1 = moodAnalyzerWithMessage.AnalyseMood();
        Console.WriteLine("Mood 1: " + mood1);

        MoodAnalyzer moodAnalyzerDefault = new MoodAnalyzer();
        string mood2 = moodAnalyzerDefault.AnalyseMood();
        Console.WriteLine("Mood 2: " + mood2);
    }
}
