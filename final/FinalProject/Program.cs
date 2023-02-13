using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string _choice = "0";
        Menu menu = new Menu();
        Console.Clear();

        while (_choice != "4")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("* Should I buy that Car? *");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Do I buy the car now with a loan while it is discounted or continue to save?"); 
            Console.WriteLine("2. Will the electric / hybrid car save me money?");
            Console.WriteLine("3. Compare all finance and a car options");
            Console.WriteLine("4. QUIT");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What decision do you need help with?  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            _choice = Console.ReadLine(); 

            if(_choice == "1")
            {
                menu.MenuBuySave();
            } 
            else if (_choice == "2")
            {
                menu.MenuElecPetrol();
            } 
            else if (_choice == "3")
            {
                menu.MenuCompareAll();
            }
        }

        Console.WriteLine("Thank you Goodbye");
        
    }
}