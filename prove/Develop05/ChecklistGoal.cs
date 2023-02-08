using System;
using System.IO;

class ChecklistGoal : Goals
{
    private bool _isComplete;
    private string _goalType = "Checklist Goal";
    private int _totalTimes, _bonus;
    public int _doneTimes;
    
   public ChecklistGoal(string name, string description, int score, bool isComplete, int times, int bonus, int done) : base (name, description, score)
    {
        _isComplete = isComplete;
        _totalTimes = times;
        _bonus = bonus;
        _doneTimes = done;
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", _goalType, GetGoalName(), GetGoalDescription(), GetGoalPoints(), _isComplete, _doneTimes, _totalTimes, _bonus);
    }

    public override void RecordEvent()
    {
                
        Console.WriteLine(string.Format("Congratulations! You have earned a total of {0}", GetGoalPoints()));
    }

    public override string ToString()
    {

        return string.Format("[{0}] {1} ({2})", ((_isComplete == false) ? " " : "X"), GetGoalName(), GetGoalDescription());
        
    }

    public override int GetGoalPoints()
    {
        _doneTimes += 1;
        if (_doneTimes == _totalTimes)
        {
            _score += _bonus;
            Console.WriteLine(string.Format("Congratulations you have completed your goal and received a bonus of {0}", _bonus));
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
            _score += 0;
        }

        return _score;
    }

}