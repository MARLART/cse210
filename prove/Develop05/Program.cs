using System;
using System.IO;

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
               menu1.MenuNewGoal();
                
            }
            else if (_menuOption == "2")
            {
                menu1.DisplayGoals(Goals._goalList);
            }

            else if (_menuOption == "3")
            {
                Console.WriteLine("menu 3");
            }

            else if (_menuOption == "4")
            {
                Console.WriteLine("menu 4");
            }

            else if (_menuOption == "5")
            {
                Console.WriteLine("menu 5");
            }

        } while (_menuOption != "6");

        Console.WriteLine("Thank you Good Bye");
    }
}