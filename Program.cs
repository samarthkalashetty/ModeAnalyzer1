
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
            if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "Happy Mood";
            }
            else if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "Sad Mood";
            }
            else
            {
                throw new Exception("Mood not recognized");
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
        Console.Write("Enter a message: ");
        string inputMessage = Console.ReadLine();

        MoodAnalyser moodAnalyser = new MoodAnalyser(inputMessage);
        string mood = moodAnalyser.AnalyseMood();
        Console.WriteLine("Mood: " + mood);
    }
}