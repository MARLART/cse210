using System;
using System.IO;

class DealingWithGoals
{
    List<Goals> _goalsList = new List<Goals>();
    public DealingWithGoals()
    {

    }

    public List<Goals> AddGoalList(Goals goal)
    {
        _goalsList.Add(goal);
        return _goalsList;
    }

    public  void DisplayGoalList()
    {
        if (_goalsList.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        foreach (Goals goal in _goalsList)
        {
            Console.WriteLine(goal.ToString());
        }
        
    }

}