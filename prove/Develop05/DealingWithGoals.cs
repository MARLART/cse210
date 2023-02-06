using System;
using System.IO;

class DealingWithGoals
{
    private List<Goals> _goalsList = new List<Goals>();
    public static int _totalPoints;

    public DealingWithGoals()
    {

    }

    public void AddGoalList(Goals goal)
    {
        _goalsList.Add(goal);
    }

    public  void DisplayGoalList()
    {
        Console.WriteLine(_goalsList.Count());
        if (_goalsList.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        foreach (Goals goal in _goalsList)
        {
            Console.WriteLine(goal.ToString());
        }
        
    }
    public void RecordingEvent()
    {
        Console.WriteLine("The goals are:");
        foreach(Goals goal in _goalsList)
        {
            Console.WriteLine(string.Format("{0} {1}", _goalsList.IndexOf(goal)+1, goal.GetGoalName()));
        }
        
        
        Console.WriteLine("Which Goal did you work on? ");
        string _choice = Console.ReadLine();
        int _iChoice = Int32.Parse(_choice);
        int _index = _iChoice - 1;

        _goalsList[_index].RecordEvent();
        _totalPoints += _goalsList[_index].GetGoalPoints();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("You now have {0} points", _totalPoints.ToString());
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}