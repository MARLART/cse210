using System;

class Breathing : Activity
{
    private string _bName = "breathing";
    private string _bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _bAction = "I am breathing";

    public Breathing() : base()
    {
        Console.Clear();
        DisplayStartMessage(_bName, _bDescription);
    }

    public void BreathInOut()
    {
        GetDuration();
        //TODO TIMER AND ANIMATION

        DisplayEndMessage(_bName);
    }

}