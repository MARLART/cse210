using System;
using System.IO;

class ChecklistGoal : Goals
{
    private int _cScore;
    private bool _cIsComplete = false;

    public ChecklistGoal()
    {
        
    }

    public ChecklistGoal(string name, string description, int score, string type) : base (name, description, score, type)
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