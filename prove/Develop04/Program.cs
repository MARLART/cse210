using System;

class Program
{
    static void Main(string[] args)
    {
        string _menuOption = "0";
        

        do
        {
            Console.Clear();
            //Display the menu
            Menu menu1 = new Menu();

            //Display the menu response
            _menuOption = Console.ReadLine();

            //option 1 breathing
            if (_menuOption == "1")
            {
                Breathing breathing1 = new Breathing();
                
            }
            else if (_menuOption == "2")
            {
                Reflection reflection = new Reflection();
            }

            else if (_menuOption == "3")
            {
                Listing listing = new Listing();
            }
        } while (_menuOption != "4");

        Console.WriteLine("Thank you Good Bye");
        

    }
}