using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Doggy", "Eating");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("pusspuss", "purring", "5", "5.1 - 5.6");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mummy", "Tired", "How to sleep more.");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}