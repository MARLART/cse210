using System;
using System.IO;

public abstract class Goals
{
    protected int _score;
    public int _totalScore = 0;
    protected string _name, _description;
    private bool _isComplete = false;
    public string _goalString;

    public Goals(string name, string description, int score)
    {
        _name = name;
        _description = description;
        _score = score;
    }

    public abstract bool IsItComplete();

    public abstract int RecordEvent();

    public string GoalToString()
    {
        _goalString = string.Format("{0} | {1} | {2} | {3}", _name, _description, _score, _isComplete);
        return _goalString;
    }

}