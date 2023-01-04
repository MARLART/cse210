using System;

class Program
{
    static void Main(string[] args)
    {
        string cont = "yes";
        string guess = "0";

        while (cont == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int noGuesses = 0;
            //Console.WriteLine(magicNumber);

            Console.WriteLine("The magic number is between 1 and 100");
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            noGuesses +=1;
            int guessNum = int.Parse(guess);

            while(!(magicNumber == guessNum))
            {
                if (magicNumber > guessNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                noGuesses +=1;
                guessNum = int.Parse(guess);
            }

            Console.WriteLine("You are correct.");
            Console.WriteLine($"You took {noGuesses} guesses.");
            Console.Write("Would you like to play again? ");
            cont = Console.ReadLine();
        }
        
        Console.WriteLine("Thank you for playing.");
    }
}