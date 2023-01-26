using System;

class Breathing : Activity
{
    private string _bName = "breathing";
    private string _bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    private int _bDuration, _time, _inOutIntervals, _numIntervals, _timeCount;
    private int _breathInterval = 2500;
    private int _countdown = 3;

    public Breathing() : base()
    {
        Console.Clear();
        _bDuration = DisplayStartMessage(_bName, _bDescription);
        
    }

    public void BreathInOut()
    {
        _time = _bDuration * 1000;
        _inOutIntervals = _breathInterval * 2;
        _numIntervals = _time / _inOutIntervals;

        //run breating based on number of intervals in the alloted time
        for(int i=1; i<=_numIntervals; i++)
        {
            Console.WriteLine("\b \b"); // Erase the character 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Breath  ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.Write("  In  ");
            //Thread.Sleep(_breathInterval);
            Countdown();

            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.Write("  Out  "); 
            //Thread.Sleep(_breathInterval);
            Countdown();
        }
        

        Console.ForegroundColor = ConsoleColor.Gray;
        DisplayEndMessage(_bName);
    }

    private void Countdown()
    {
        _timeCount = _breathInterval / _countdown;

        //create a countdown from 5 to 1
        for(int i=_countdown; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(_timeCount);
            Console.Write("\b \b"); // Erase the character    
        }
    }

}