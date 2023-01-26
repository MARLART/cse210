using System;

class Activity
{
    protected string _welcomeMessage, _usageMessage, _description, _name, _capName; 
    protected string _durationQuestion = "How long, in seconds, would you like for your session? ";
    protected string _endMessage = "Well done!!";
    protected int _duration = 0;

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
        Console.Write(_durationQuestion);

        //get information from duration question
        GetDuration();
        
    }

    protected int GetDuration()
    {
        _duration = Convert.ToInt32(Console.ReadLine());
        return _duration;
        
    }


    private void PauseAnimation()
    {
        Thread.Sleep(3000);
    }

    protected void DisplayEndMessage(string name)
    {
        _name = name;
        _endMessage = $"You have completed andother {_duration} of the {_name} activity.";

        Console.WriteLine(_endMessage);
    }


}