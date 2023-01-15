using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> uppers = new List<string>();
        uppers.Add("A");
        uppers.Add("B");

        List<string> lowers = new List<string>();
        lowers.Add("a");
        lowers.Add("b");



        foreach (string combo in lowers)
        {
            Console.WriteLine(combo);
        }


    }
}
