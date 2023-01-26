using System;

class Breathing : Activity
{
    private string _bName = "breathing";
    private string _bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    private int _bDuration, _time;
    //private string _bAction = "I am breathing";

    public Breathing() : base()
    {
        Console.Clear();
        _bDuration = DisplayStartMessage(_bName, _bDescription);
        
    }

    public void BreathInOut()
    {
        _time = _bDuration * 100;

        Console.Write("+");

        Thread.Sleep(_time/2);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(_time/2);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("+"); // Replace it with the - character


        DisplayEndMessage(_bName);
    }

}