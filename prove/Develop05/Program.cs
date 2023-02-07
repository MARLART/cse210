using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string _menuOption = "0";
        Console.Clear();
        DealingWithGoals deal = new DealingWithGoals();

        do
        {            
            //Display the menu
            Menu menu1 = new Menu();
            DealingWithGoals dealGoal = new DealingWithGoals();
      
            //Display the menu response
            _menuOption = Console.ReadLine();

            //option 1 breathing
            if (_menuOption == "1")
            {
               menu1.MenuNewGoal();
                
            }
            else if (_menuOption == "2")
            {
                menu1.MenuDisplayGoals();
            }

            else if (_menuOption == "3")
            {
                menu1.MenuSaveGoals();
            }

            else if (_menuOption == "4")
            {
                menu1.MenuLoadGoals();
            }

            else if (_menuOption == "5")
            {
                menu1.MenusRecordGoals();
            }

        } while (_menuOption != "6");

        Console.WriteLine("Thank you Good Bye");
    }

}