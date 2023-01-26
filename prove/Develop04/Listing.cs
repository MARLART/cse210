using System;

class Listing : Activity
{
    private string _lName = "listing";
    private string _lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    private string _lAction = "I am Listing";

    public Listing() : base()
    {
        Console.Clear();
        DisplayStartMessage(_lName, _lDescription);
    }

    public void BreathInOut()
    {
        GetDuration();
        //TODO TIMER AND ANIMATION

        DisplayEndMessage(_lName);
    }

}