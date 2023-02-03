using System;
using System.IO;

class EternalGoal : Goals
{
    private int _eScore;
    private bool _eIsComplete = false;

    public EternalGoal()
    {

    }

    public EternalGoal(string name, string description, int score, string type) : base (name, description, score, type)
    {
        
        
    }

    public override bool IsItComplete()
    {
        //can never be completed so always false
        return false;
    }

    public override int RecordEvent(int index)
    {
        int _score = Goals._scoreList[index];
        Goals._totalScore += _score;
        IsItComplete();
        return Goals._totalScore;
    }

}