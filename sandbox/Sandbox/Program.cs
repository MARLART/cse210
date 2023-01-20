using System;

class Program
{
    static void Main(string[] args)
    {
      string _stringWords = "I am a good dog.";
      

      foreach (string item in _stringWords.Split())
      {
        Console.WriteLine(item);
      }




    }
}
