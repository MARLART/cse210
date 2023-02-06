using System;
using System.IO;

public abstract class Goals
{
    protected int _score, _times, _bonus;
    protected string _name, _description, _completeSymbol;
    public string _goalString;


    public Goals(string name, string description, int score)
    {
        _name = name;
        _description = description;
        _score = score;

    }

    public abstract void RecordEvent();

    public abstract string ToCSVRecord();

    public string GetGoalName()
    {
        return _name;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public int GetGoalPoints()
    {
        return _score;
    }

}