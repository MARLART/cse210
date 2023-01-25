using System;

class Activity
{
    protected string _welcomeMessage, _endMessage, _usageMessage, _description, _name; 
    protected string _durationQuestion = "How long, in seconds, would you like for your session? ";
    protected int _duration;

    public Activity()
    {

    }

    protected  void DisplayStartMessage(string name, string description)
    {
        //assign variables 
        _name = name;
        _description = description;
        _welcomeMessage = $"Welcome to the {_name} Activity.";

        Console.WriteLine(_welcomeMessage);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine(_durationQuestion);
        
    }


}