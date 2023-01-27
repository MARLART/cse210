using System;
using System.Diagnostics;

class Reflection : Activity
{
    private string _rName = "reflection";
    private string _rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."; 
    private List<string> _prompt = new List<string>();
    private List<string> _questions = new List<string>();
    private int _lengthPrompt, _lengthQuestion, _rDuration, _time, _countdown;
    private long _remainingTime;
    private string _message;

    public Reflection() : base()
    {
        Console.Clear();
        _lengthPrompt = CreateListPrompt();
        _lengthQuestion = CreateListQuestions();
        _rDuration = DisplayStartMessage(_rName, _rDescription);
    }

    private int CreateListPrompt()
    {
        string[] prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};  

        _prompt.AddRange(prompts); 

        return _prompt.Count();
    }

    private int CreateListQuestions()
    {
        string[] q = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};  

        _questions.AddRange(q); 

        return _questions.Count();
    }

    public void SelectPrompt()
    {
        _time = _rDuration *1000;
        _countdown = 5;
        _message = "You may begin in: ";

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Random random = new Random();
        int i = random.Next(0, _lengthPrompt);
        Console.WriteLine(string.Format("--- {0} ---",_prompt[i]));
        Console.WriteLine();
        Console.WriteLine("Once you have thought of an experience press enter.");
        Console.ReadLine();

        long _count = stopwatch.ElapsedMilliseconds;

        displayCountDown(_countdown, _message);

        if (_count < _time)
        {
            _remainingTime  = _time - _count;            

            SelectQuestion(_remainingTime);
        }
        else
        {
            DisplayEndMessage(_rName);
        }        

    }

    private void SelectQuestion(long remainingTime)
    {
        _remainingTime = remainingTime;
        _countdown = 5;
        _message = "";

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        long _count = 0;

        while(_count < _remainingTime)
        {
            Random random = new Random();
            int i = random.Next(0, _lengthQuestion);
            Console.WriteLine(string.Format("> {0}", _questions[i]));

            displayCountDown(_countdown, _message);
            
            _count = stopwatch.ElapsedMilliseconds;
        }
        
        DisplayEndMessage(_rName);

    }


}