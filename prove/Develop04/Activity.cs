using System;

class Activity
{
    protected string _welcomeMessage, _description, _name; 
    protected string _durationQuestion = "How long, in seconds, would you like for your session? ";
    protected string _endMessage = "Well done!!";
    protected int _duration;
    protected string _seconds;

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
        Console.WriteLine(_duration + 10); 
        return _duration;   
    }



    private void PauseAnimation()
    {
        Thread.Sleep(3000);
    }

    protected void DisplayEndMessage(string name)
    {
        _name = name;
        _endMessage = $"You have completed another {_duration} seconds of the {_name} activity.";

        Console.WriteLine(_endMessage);
    }


}