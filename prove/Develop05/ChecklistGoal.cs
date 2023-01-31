using System;
using System.IO;

class ChecklistGoal : Goals
{
    private int _cScore;
    private bool _cIsComplete = false;

    public ChecklistGoal(string name, string description, int score) : base (name, description, score)
    {
        Console.WriteLine("I am a checklist Goal");
        
    }

    public override bool IsItComplete()
    {
        Console.WriteLine("I am a checklist Goal");
        return false;
    }

    public override int RecordEvent()
    {
        return 57;
    }

}