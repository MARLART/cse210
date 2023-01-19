using System;

class Program
{
    static void Main(string[] args)
    {
        string _book, _chapter, _verse;
        string _endVerse = "";
        //gather the details of the scripture to be memorised 
        //begin with the reference
        Console.WriteLine("Scripture Memoriser");
        Console.WriteLine("Lets start with the scripture reference.");
        Console.Write("Book: ");
        _book = Console.ReadLine();
        Console.Write("Chapter: ");
        _chapter = Console.ReadLine();
        Console.Write("Start verse: ");
        _verse = Console.ReadLine();

        //check if there is more than 1 verse
        Console.Write("Is there more than one verse? (Y/N): ");
        string _answer = Console.ReadLine();

        //if there is more than one verse ask for the last verse
        if (_answer == "Y" || _answer == "y")
        {
            Console.Write("End verse: ");
             _endVerse = Console.ReadLine();             
        }

        //get the text of the Scripture and send them to Scrpture
        Console.Write("Please type the scripture: ");
        string _text = Console.ReadLine();

        //create reference and scripture
        Reference _ref = new Reference(_book, _chapter, _verse, _endVerse);
        Scripture _newScripture = new Scripture(_text);

        //get reference and scripture to show on the screen
        // This will clear the console
        Console.Clear();
        _ref.Show();
        _newScripture.GetRenderedText();
        Console.WriteLine("");

        
    }
}