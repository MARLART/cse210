using System;
using System.IO;

class Menu
{
    //Main menu variables
    private string _menuWelcome ="* Eternal Quest *";    
    private string _menu0 = "Menu Options:";
    private string _menu1 = "1. Create New Goal";
    private string _menu2 = "2. List Goals";
    private string _menu3 = "3. Save Goals";
    private string _menu4 = "4. Load Goals";
    private string _menu5 = "5. Record Event";
    private string _menu6 = "6. Quit";
    private string _menu7 = "Select a choice from the menu: ";

//  types of goals
    private string _simple = "1. Simple Goal";
    private string _eternal = "2. Eternal Goal";
    private string _checklist = "3. Checklist Goal";
    private string _choice, _name, _description, _score;
    private int _iScore;

    public Menu()
    {
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(_menuWelcome);
        //TODO add total score to introduction
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(_menu0);
        Console.WriteLine(_menu1);
        Console.WriteLine(_menu2);
        Console.WriteLine(_menu3);
        Console.WriteLine(_menu4);
        Console.WriteLine(_menu5);
        Console.WriteLine(_menu6);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(_menu7);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void MenuNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(_simple);
        Console.WriteLine(_eternal);
        Console.WriteLine(_checklist);

        Console.Write("Which type of goal would you like to create? ");
        _choice = Console.ReadLine();


        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("How many points for doing this goal? ");
        _score = Console.ReadLine();
        _iScore = Int32.Parse(_score);

        if (_choice == "1")
        {
            SimpleGoal simple = new SimpleGoal(_name, _description, _iScore);
            
        }
        else if (_choice == "2")
        {
            EternalGoal eternal = new EternalGoal(_name, _description, _iScore);
        }
        else if (_choice == "3")
        {
            ChecklistGoal checklist = new ChecklistGoal(_name, _description, _iScore);
        }
    }

    public void DisplayGoals(List<string> goalList)
    {
        int _numGoals = goalList.Count();

        //loop the list of Goals and display them 
        //TODO add completed string and chklist string
        for(int i =0; i< _numGoals; i++)
        {
            Console.WriteLine(goalList[i]);
        }
    }

}