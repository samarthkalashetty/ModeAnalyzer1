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
            if (message == null)
            {
                throw new MoodAnalysisException("Mood is NULL.");
            }
            else if (message.Trim() == "")
            {
                return "HAPPY";
            }
            else if (message.Contains("Sad"))
            {
                throw new MoodAnalysisException("Mood is sad.");
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
        Console.WriteLine("Enter a mood message (or leave empty for NULL):");
        string userInput = Console.ReadLine();

        MoodAnalyzer moodAnalyzer = new MoodAnalyzer(userInput);
        string mood = moodAnalyzer.AnalyseMood();
        Console.WriteLine("Mood: " + mood);
    }
}
