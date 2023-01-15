public class Entry
{
    public string _randomPrompt = "";  
    DateTime todayDate = DateTime.Now;
    public string _date;
    public string _entry = "";

    public Entry()
    {
        _date = todayDate.ToString();
    }

    public void Display()
    {
        Prompt RanPrompt = new Prompt();
        RanPrompt.DisplayRandomPrompt();
        Console.Write(_date);
        _entry = Console.ReadLine();
    }

}