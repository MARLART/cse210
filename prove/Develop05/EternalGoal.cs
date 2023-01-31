using System;
using System.IO;

class EternalGoal : Goals
{
    private int _eScore;
    private bool _eIsComplete = false;

    public EternalGoal(string name, string description, int score) : base (name, description, score)
    {
        Console.WriteLine("I am an eternal Goal");
        
    }

    public override bool IsItComplete()
    {
        //can never be completed so always false
        return false;
    }

    public override int RecordEvent()
    {
        return 57;
    }

}