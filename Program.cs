using System;

enum MoodAnalysisError
{
    NULL_MOOD,
    EMPTY_MOOD,
    SAD_MOOD
}

class MoodAnalysisException : Exception
{
    public MoodAnalysisError Error { get; }

    public MoodAnalysisException(string message, MoodAnalysisError error) : base(message)
    {
        Error = error;
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
                throw new MoodAnalysisException("Mood is null.", MoodAnalysisError.NULL_MOOD);
            }
            else if (message.Trim() == "")
            {
                throw new MoodAnalysisException("Mood is empty.", MoodAnalysisError.EMPTY_MOOD);
            }
            else if (message.Contains("Sad"))
            {
                throw new MoodAnalysisException("Mood is sad.", MoodAnalysisError.SAD_MOOD);
            }
            else
            {
                return "HAPPY";
            }
        }
        catch (MoodAnalysisException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
            Console.WriteLine("Error Type: " + ex.Error);
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

        MoodAnalyzer moodAnalyzer = null;
        if (userInput != null && userInput.Trim() != "")
        {
            moodAnalyzer = new MoodAnalyzer(userInput);
        }
        else
        {
            moodAnalyzer = new MoodAnalyzer();
        }

        string mood = moodAnalyzer.AnalyseMood();
        Console.WriteLine("Mood: " + mood);
    }
}

