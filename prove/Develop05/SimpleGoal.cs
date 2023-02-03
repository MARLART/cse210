using System;
using System.IO;

class SimpleGoal : Goals
{
    private int _sScore;
    private bool _sIsComplete = false;

    public SimpleGoal()
    {
        
    }
    
    public SimpleGoal(string name, string description, int score, string type) : base (name, description, score, type)
    {
                
    }

    public override bool IsItComplete()
    {
        return true;
    }

    public override int RecordEvent(int index)
    {
        int _score = Goals._scoreList[index];
        Goals._totalScore += _score;
        IsItComplete();
        return Goals._totalScore;
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _goalType, _name, _description, _score(), IsItComplete() )
    }

}