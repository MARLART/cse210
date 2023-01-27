using System;

class Program
{
    static void Main(string[] args)
    {

      Console.WriteLine("You may begin in: ");
      for (int i = 5; i >=0; i--)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(string. Format (" {0}", i));
        Console.SetCursorPosition(0, Console.CursorTop);
        Thread.Sleep(1000);
      }

      Console.ForegroundColor = ConsoleColor.Gray;
    }
}
