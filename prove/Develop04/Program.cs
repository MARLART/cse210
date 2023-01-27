using System;

class Program
{
    static void Main(string[] args)
    {
        

        string _menuOption = "0";
        Console.Clear();

        do
        {            
            //Display the menu
            Menu menu1 = new Menu();

            //Display the menu response
            _menuOption = Console.ReadLine();

            //option 1 breathing
            if (_menuOption == "1")
            {
                Breathing breathing1 = new Breathing();
                
                breathing1.BreathInOut();
                
            }
            else if (_menuOption == "2")
            {
                Reflection reflection1 = new Reflection();
                reflection1.SelectPrompt();
            }

            else if (_menuOption == "3")
            {
                Listing listing1 = new Listing();
            }
        } while (_menuOption != "4");

        Console.WriteLine("Thank you Good Bye");
        

    }
}