using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string textNumber = Console.ReadLine();
        int number = int.Parse(textNumber);

        while(!(number == 0))
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            textNumber = Console.ReadLine();
            number = int.Parse(textNumber);
        }

        //calculate the sum  average and largest of the numbers
        int max = numbers[0];
        float sum = 0;
        
        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
            {
                max = num;
            }
        }
        int smallPos = max;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallPos)
            {
                smallPos = num;
            }
        }
        float ave = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave.ToString("N2")}");
        Console.WriteLine($"The largest number  is: {max}");
        Console.WriteLine($"The smallest positive number  is: {smallPos}");
        Console.WriteLine($"The sorted list is: ");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}