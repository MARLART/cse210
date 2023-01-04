using System;

class Program
{
    static void Main(string[] args)
    {
        string grade;
        float calcSign;
        string sign;

        Console.Write("What is your grade percentage? ");
        string textPercent = Console.ReadLine();
        float percent = float.Parse(textPercent);
        calcSign = percent % 10;

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent>= 80)
        {
            grade = "B";
        }
        else if (percent>= 70)
        {
            grade = "C";
        }
        else if (percent>= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }

        if (percent <= 60 || percent >=97)
        {
            sign = "";
        }
        else
        {
            if (calcSign < 3)
            {
                sign = "-";
            }
            else if (calcSign >= 7)
            {
                sign = "+";
            }
            else 
            {
                sign = "";
            }
        }
        

        Console.WriteLine($"You earned a {grade}{sign}.");
        if(percent >= 70)
        {
            Console.WriteLine("Congratulations you passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course, better luck next time.");
        }
    }
}