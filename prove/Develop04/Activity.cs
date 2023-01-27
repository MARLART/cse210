using System;
using System.Diagnostics;

class Activity
{
    protected string _welcomeMessage, _description, _name, _seconds; 
    protected string _durationQuestion = "How long, in seconds, would you like for your session? ";
    protected string _endMessage = "Well done!!";
    protected int _duration;
    private int _spinnerCounter = 1;
    private int _pauseTime = 5;


    public Activity()
    {

    }

    protected  int DisplayStartMessage(string name, string description)
    {
        //assign variables 
        _name = name;
        _description = description;
        _welcomeMessage = $"Welcome to the {_name} Activity.";    
        
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write(_durationQuestion);
        _seconds = Console.ReadLine();
        _duration = int.Parse(_seconds);

        //pause animation
        Console.WriteLine("Get Ready .... ");
        DisplaySpinner(_pauseTime);

        return _duration;   
    }

    protected void DisplayEndMessage(string name)
    {
        _name = name;

        _endMessage = $"You have completed another {_duration} seconds of the {_name} activity.";

        Console.WriteLine();
        Console.WriteLine("Well Done!");
        DisplaySpinner(_pauseTime);
        Console.WriteLine();
        Console.WriteLine(_endMessage);
        Console.WriteLine();
        DisplaySpinner(_pauseTime);
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while ((stopwatch.ElapsedMilliseconds / 1000) < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the character   
        }

    }


}