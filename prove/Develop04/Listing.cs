using System;
using System.Diagnostics;

class Listing : Activity
{
    private string _lName = "listing";
    private string _lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    private List<string> _questions = new List<string>();
    private int  _lDuration, _lengthQuestion, _time, _countdown;
    private int _counter = 0;
    private string _message;

    public Listing() : base()
    {
        Console.Clear();
        _lengthQuestion = CreateListQuestions();
        _lDuration = DisplayStartMessage(_lName, _lDescription);
    }

    private int CreateListQuestions()
    {
        string[] q = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};  

        _questions.AddRange(q); 

        return _questions.Count();
    }

    public void SelectQuestion()
    {
        _time = _lDuration *1000;
        _countdown = 5;
        _message = "You may begin in: ";

        Random random = new Random();
        int i = random.Next(0, _lengthQuestion);
        Console.WriteLine(string.Format("--- {0} ---",_questions[i]));
        displayCountDown(_countdown, _message);
        Console.WriteLine();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        long _count = 0;

        while(_count < _time)
        {
            Console.Write("> ");
            Console.ReadLine();
            _counter++;
            _count = stopwatch.ElapsedMilliseconds;
        }
        Console.WriteLine(string.Format("You listed {0} items!", _counter));
        DisplayEndMessage(_lName);

    }
}