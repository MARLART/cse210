using System;

class Program
{
    static void Main(string[] args)
    {
        //gather the details of the scripture to be memorised 
        //begin with the reference
        Console.WriteLine("Scripture Memoriser");
        Console.WriteLine("Lets start with the scripture reference.");
        Console.Write("Book: ");
        string _book = Console.ReadLine();
        Console.Write("Chapter: ");
        string _chapter = Console.ReadLine();
        Console.Write("Start verse: ");
        string _verse = Console.ReadLine();

        //check if there is more than 1 verse
        Console.Write("Is there more than one verse? (Y/N): ");
        string _answer = Console.ReadLine();

        //if there is more than one verse ask for the last verse
        if (_answer == "Y" || _answer == "y")
        {
            Console.Write("End verse: ");
            string _endVerse = Console.ReadLine();

            // create a reference object to hold the reference
            Reference _ref = new Reference(_book, _chapter, _verse, _endVerse);
            _ref.Show();
        }

        //if there is only 1 verse
        else
        {
            // create a reference object to hold the reference
            Reference _ref = new Reference(_book, _chapter, _verse);
            _ref.Show();
        }

        
    }
}