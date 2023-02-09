using System;
using System.IO;

class DealingWithGoals
{
    private List<Goals> _goalsList = new List<Goals>();
    public static int _totalPoints;
    Pets pet = new Pets();

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

        //praise
        Congratulations();
    }

    public void SaveGoals()
    {
        if (_goalsList.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            return;
        }

        string _fileToSave = GoalFile();

        List<string> SaveGoalsString = new List<string>();

        SaveGoalsString.Add(_totalPoints.ToString());

        foreach (Goals goal in _goalsList)
        {
            SaveGoalsString.Add(goal.ToCSVRecord());
        }

        SaveLoadCSV.SaveToCSV(SaveGoalsString, _fileToSave);

        Console.WriteLine("Goals saved.");  
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public string GoalFile()
    {
        Console.Write("What is the file name for your goals file? ");
        return Directory.GetCurrentDirectory() + Console.ReadLine();
    }

    public void LoadGoals()
    {
        List<string> _fileGoals = new List<string>();
            //if you don't have the file name you are saking what the file name is
        _fileGoals = SaveLoadCSV.LoadFromCSV(GoalFile());
            
        Goals goal = null;
        foreach (string _goalInFile in _fileGoals)
        {
            //split each line according to the line shape
            string[] _goalParts = _goalInFile.Split("|");
            string _goalType = (_goalParts[0]);

            if (_goalType == "Simple Goal")
            {
                goal = new SimpleGoal(_goalParts[1], _goalParts[2], int.Parse(_goalParts[3]), bool.Parse(_goalParts[4]));
            }

            else if (_goalType == "Eternal Goal")
            {
                goal = new EternalGoal(_goalParts[1], _goalParts[2], int.Parse(_goalParts[3]), bool.Parse(_goalParts[4]));
            }

            else if (_goalType == "Checklist Goal")
            {
                goal = new ChecklistGoal(_goalParts[1], _goalParts[2], int.Parse(_goalParts[3]), bool.Parse(_goalParts[4]), int.Parse(_goalParts[7]),int.Parse(_goalParts[6]), int.Parse(_goalParts[7]));
                
            }

            else
            //if the line does not contain a real goal type then it must be  the total points
            {
                _totalPoints = int.Parse(_goalType);
            }
            
            //make sure the goal exists and the list does not already contain the goal
            if (goal != null && _goalsList.Contains(goal) == false)
            {
                _goalsList.Add(goal);
            }
        }
        Console.WriteLine("Goals Loaded");

    }

    private void Congratulations()
    {
        if (_totalPoints > 50)
        {
            pet.Doggy();
        }

    }

    
}