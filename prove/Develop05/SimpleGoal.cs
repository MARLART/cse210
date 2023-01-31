using System;
using System.IO;

class SimpleGoal : Goals
{
    private int _sScore;
    private bool _sIsComplete = false;

    public SimpleGoal(string name, string description, int score) : base (name, description, score)
    {
        Console.WriteLine("I am a simple Goal");
        
    }

    public override bool IsItComplete()
    {
        Console.WriteLine("I am a simple Goal");
        return false;
    }

    public override int RecordEvent()
    {
        return 57;
    }

}