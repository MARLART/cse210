using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _myJournal = new Journal();
        string i = "0";

        while (i != "5")
        {

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            i = Console.ReadLine();

            if (i == "1")
            {    
                _myJournal.AddEntry();
                Console.WriteLine($"Did it return? ");
                _myJournal.DisplayEntries();
 
            }

            else if (i == "2")
            {
               _myJournal.DisplayEntries();
            }

            else if (i == "3")
            {
                Console.WriteLine("option 3");
            }

            else if (i == "4")
            {
                Console.WriteLine("option 4");
            }

            else 
            {
                Console.WriteLine("Thank you Good Bye");
            }
        }
                
    }
}