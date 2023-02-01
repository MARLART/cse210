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
                menu1.DisplayGoals(Goals._goalList);
                Console.WriteLine("Which Goal did you work on? ");
                string _choice = Console.ReadLine();
                int _iChoice = Int32.Parse(_choice);
                int _score = Goals._scoreList[_iChoice-1];
                Goals._totalScore += _score;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Well Done!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        } while (_menuOption != "6");

        Console.WriteLine("Thank you Good Bye");
    }
}