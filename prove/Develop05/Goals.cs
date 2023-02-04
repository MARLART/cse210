using System;
using System.IO;

public abstract class Goals
{
    protected int _score, _times, _bonus;
    public static int _totalScore = 0;
    protected string _name, _description, _completeSymbol;
    public string _goalString;
    public static string _goalType;
    public static List<string> _goalList = new List<string>();
    public static List<int> _scoreList = new List<int>();
    public static List<string> _typeList = new List<string>();
    public static List<int> _timesList = new List<int>();
    public static List<int> _bonusList = new List<int>();
    public static List<bool> _goalCompleteList = new List<bool>();
    private bool _goalComplete;
    public Goals()
    {

    }

    public Goals(string name, string description, int score, string type, int times, int bonus)
    {
        _name = name;
        _description = description;
        _score = score;
        _goalType = type;
        _times = times;
        _bonus = bonus;
        _goalComplete = false;

        ScoreToList(_score);
        TypeToList(_goalType);
        TimesToList(_times);
        BonusToList(_bonus);
       // CompleteToList(_goalComplete);
    }

    public abstract bool IsItComplete();

    public abstract int RecordEvent(int index);

    //public abstract string ToCSVRecord();


    protected static List<string> GoalToList(string goalString)
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

     private List<int> TimesToList(int times)
    {
        _timesList.Add(times);
        return _timesList;
    }

    private List<int> BonusToList(int bonus)
    {
        _bonusList.Add(bonus);
        return _bonusList;
    }

    private List<bool> CompleteToList()
    {
        _goalCompleteList.Add(_goalComplete);
        return _goalCompleteList;
    }

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