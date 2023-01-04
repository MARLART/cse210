using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(userName, square);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program.");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            return number;
        }
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }
        static void DisplayResult(string name, int sqNum)
        {
            Console.WriteLine($"{name}, the square of your number is {sqNum}.");
        }
    }   
}