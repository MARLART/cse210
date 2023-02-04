using System;
using System.IO;

class SimpleGoal : Goals
{
    private bool _isComplete = false;


    public SimpleGoal()
    {
        
    }
    
    public SimpleGoal(string name, string description, int score, string type, int times, int bonus) : base (name, description, score, type, times, bonus)
    {
        
    }

    public override bool IsItComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override int RecordEvent(int index)
    {
        int _score = Goals._scoreList[index];
        SimpleGoal._goalCompleteList[index] = IsItComplete();
        Goals._totalScore += _score;
        return Goals._totalScore;
    }

    public override string ToString()
    {

        _goalString = string.Format("Goal: {0} ({1}) Points: {2}.", GetGoalName(), GetGoalDescription(), GetGoalPoints());
        SimpleGoal.GoalToList(_goalString); 
        return _goalString;
    }




    //public override string ToCSVRecord()
   // {
       // return string.Format("{0}|{1}|{2}|{3}|{4}", _goalType, _name, _description, _score(), IsItComplete() );
   // }

}