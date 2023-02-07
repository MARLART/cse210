using System;
using System.IO;

class SimpleGoal : Goals
{
    private bool _isComplete;
    private string _goalType = "Simple Goal";
    
    public SimpleGoal(string name, string description, int score, bool isComplete) : base (name, description, score)
    {
        _isComplete = isComplete;
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _goalType, GetGoalName(), GetGoalDescription(), GetGoalPoints(), _isComplete);
    }

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You have earned {0}", GetGoalPoints()));
        _isComplete = true;
    }

    public override string ToString()
    {

        return string.Format("[{0}] {1} ({2})", ((_isComplete == false) ? " " : "X"), GetGoalName(), GetGoalDescription());
        
    }

}