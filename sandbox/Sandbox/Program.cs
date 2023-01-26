using System;

class Program
{
    static void Main(string[] args)
    {
      DateTime startTime = DateTime.Now;
      DateTime futureTime = startTime.AddSeconds(10000);

      Console.Clear();

      Console.WriteLine("Start Break");

      Thread.Sleep(2000);

      Console.WriteLine("End Break");

      DateTime currentTime = DateTime.Now;
      if (currentTime < futureTime)
      {
          Console.WriteLine("We have not arrived at our future time yet...");
      }

      Console.WriteLine("after add seconds");

      Thread.Sleep(2000);

      Console.WriteLine("Ended");


    }
}
