using System;
using System.IO;

public abstract class Goals
{
    protected int _score;
    public int _totalScore = 0;
    protected string _name, _description, _completeSymbol;
    private bool _isComplete = false;
    public string _goalString;
    public static List<string> _goalList = new List<string>();
    public static List<int> _scoreList = new List<int>();

    public Goals(string name, string description, int score)
    {
        _name = name;
        _description = description;
        _score = score;
        GoalToString();

    }

    public abstract bool IsItComplete();

    public abstract int RecordEvent();

    private string GoalToString()
    {
        if (_isComplete == false)
        {
            _completeSymbol = "[ ]";
        }
        else
        {
            _completeSymbol = "[X]";
        }
        _goalString = string.Format("{0} Goal: {1} ({2}) Points: {3}.", _completeSymbol,  _name, _description, _score);
        GoalToList(_goalString); 
        return _goalString;
    }

    private List<string> GoalToList(string goalString)
    {
        _goalList.Add(goalString);
        return _goalList;
    }

    


}