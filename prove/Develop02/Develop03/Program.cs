using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _scriptureRef = new Reference("Proverbs", "3", "5", "6");
        Scripture _scripture = new Scripture(_scriptureRef, "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all they ways acknownledge him, and he shall direct thy paths.");
        Word _words = new Word(_scripture);

        string _userInput = "";

        while(_userInput != "quit" && _words.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", _scriptureRef.toString(), _words.toString()));
            Console.WriteLine();
            Console.WriteLine("Press enter to remove some words or quit to end.");
            Console.WriteLine();
            _userInput = Console.ReadLine();           
            _words.HideWords();
        }
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", _scriptureRef.toString(), _words.toString()));
        Console.WriteLine();
        Console.WriteLine("Good Bye");
    }
        
}