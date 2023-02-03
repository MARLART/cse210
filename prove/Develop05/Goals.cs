using System;
using System.IO;

public abstract class Goals
{
    protected int _score;
    public static int _totalScore = 0;
    protected string _name, _description, _completeSymbol;
    private bool _isComplete = false;
    public string _goalString;
    public static string _goalType;
    public static List<string> _goalList = new List<string>();
    public static List<int> _scoreList = new List<int>();
    public static List<string> _typeList = new List<string>();

    public Goals()
    {

    }

    public Goals(string name, string description, int score, string type)
    {
        _name = name;
        _description = description;
        _score = score;
        _goalType = type;
        GoalToString();
        ScoreToList(_score);

    }

    public abstract bool IsItComplete();

    public abstract int RecordEvent(int index);

    public abstract string ToCSVRecord();

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

    private List<int> ScoreToList(int score)
    {
        _scoreList.Add(score);
        return _scoreList;
    }

    private List<string> TypeToList(string type)
    {
        _typeList.Add(type);
        return _typeList;
    }

    public void SaveGoals()
    {
        if (_goalList.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            return;
        }
        //TODO CREATE DISPLAYGETGOAL FILE
        string _fileToSave = DisplayGetGoalFile();
        //Load goals first in case the user hasn't loaded them.
        if (File.Exists(_fileToSave))
        {
            //TODO CREATE LOADGOALS
            LoadGoals();
        }

        List<string> _saveGoals = new List<string>();
        //save the points first
        _saveGoals.Add(_totalScore.ToString());

        //loops through all goals and convert them to s CSV record to be saved.
        foreach (Goals goal in _goalList)
        {
            //TODO CREATE TO CSV METHORD
            _saveGoals.Add(goal.ToCSVRecord());
        }

        SaveLoadCSV.SaveToCSV(_saveGoals, _fileToSave);

        Console.WriteLine("Goals saved.");  
        
    }


}