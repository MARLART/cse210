using System;

class Program
{
    static void Main(string[] args)
    {
        string _menuOption = "0";

        do
        {
            //Display the menu
            Menu menu1 = new Menu();

            //Display the menu response
            _menuOption = Console.ReadLine();

            //option 1 breathing
            if (_menuOption == "1")
            {
                Console.WriteLine("I am breathing");
            }
            else if (_menuOption == "2")
            {
                Console.WriteLine("I am reflecting");
            }

            else if (_menuOption == "3")
            {
                Console.WriteLine("I am listing");
            }
        } while (_menuOption != "4");

        Console.WriteLine("Thank you Good Bye");
        

    }
}