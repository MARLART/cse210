using System;

class Reflection : Activity
{
    private string _rName = "reflection";
    private string _rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string _rAction = "I am reflection";

    public Reflection() : base()
    {
        Console.Clear();
        DisplayStartMessage(_rName, _rDescription);
    }

    public void BreathInOut()
    {
        //TODO TIMER AND ANIMATION

        DisplayEndMessage(_rName);
    }

}