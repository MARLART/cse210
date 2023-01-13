public class Prompt
{
    public List<string> _prompt = new List<string>();  
    
    public Prompt()
    {
        _prompt.Add("Who was the most interesting person I interacted with today?");
        _prompt.Add("What was the most beatiful thing I saw today?");
        _prompt.Add("How was I kind today?");
        _prompt.Add("What was the best part of my day?");
        _prompt.Add("How did I see the hand of the Lord in my life today?");
        _prompt.Add("What was the strongest emotion I felt today?");
        _prompt.Add("If I had one thing I could do over today, what would it be?");
    }

    public void DisplayRandomPrompt()
    {
        int len = _prompt.Count();
        int ran = new Random().Next(0,len);
        Console.WriteLine($"{_prompt[ran]}");
    }

}