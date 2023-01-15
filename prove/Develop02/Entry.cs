public class Entry
{
    public string _randomPrompt = "";  
    DateTime todayDate = DateTime.Now;
    public string _date;
    public string _entry = "";
    public string _fullEntry = "";

    public Entry()
    {
        _date = todayDate.ToString();
    }

    public void Display()
    {
        Prompt RanPrompt = new Prompt();
        string prom = RanPrompt.DisplayRandomPrompt();
        Console.WriteLine(_date);
        _entry = Console.ReadLine();
        _fullEntry = prom +" "+ _date +" "+ _entry;
        Console.WriteLine(_fullEntry);
    }

}