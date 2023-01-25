using System;

class Breathing : Activity
{
    private string _bName = "breathing";
    private string _bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public Breathing() : base()
    {
        DisplayStartMessage(_bName, _bDescription);
    }

}