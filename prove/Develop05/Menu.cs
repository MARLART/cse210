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
    public static List<Goals> _goalsList = new List<Goals>();

    public Menu()
    {
        DisplayMenu();
        
        
    }

    private void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(_menuWelcome);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(string.Format("Total Score: {0}", Goals._totalScore));
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
            SimpleGoal simple = new SimpleGoal(_name, _description, _iScore, "S", 0, 1);
            DealingWithGoals dealing = new DealingWithGoals();
            dealing.AddGoalList(simple);
            dealing.DisplayGoalList();
            
                       
        }
        else if (_choice == "2")
        {
            //EternalGoal eternal = new EternalGoal(_name, _description, _iScore, "E", 0, 0);
           Console.Write("eternal goal");
        }
        else if (_choice == "3")
        {
            Console.Write("How many times to complete your goal? ");
            string _times = Console.ReadLine();
            int _iTimes = Int32.Parse(_times);

            Console.Write("What is the bouns score for completing the goal? ");
            string _bonus = Console.ReadLine();
            int _iBonus = Int32.Parse(_bonus);

            //ChecklistGoal checklist = new ChecklistGoal(_name, _description, _iScore, "C", _iTimes, _iBonus);
            Console.Write("checklist goal ");
        }
    }


    public void MenuEvent()
    {
        Console.WriteLine("Which Goal did you work on? ");
        string _choice = Console.ReadLine();
        int _iChoice = Int32.Parse(_choice);
        int _index = _iChoice - 1;

        // us the number of the chice to get the index for hteinformation we need in the different lists
        string _type = Goals._typeList[_index];
        

        //Go to method depending on type of goal
        if (_type == "S")
        {
           var sgoal = new SimpleGoal();
           sgoal.RecordEvent(_index);
        }
        else if (_type =="E")
        {
           // var egoal = new EternalGoal();
            //egoal.RecordEvent(_index);
            Console.WriteLine("eternal");
        }
        else
        {
           // var cgoal = new ChecklistGoal();
            //cgoal.RecordEvent(_index);
            Console.WriteLine("checklist ");
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Well Done!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}