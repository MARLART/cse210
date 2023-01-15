public class Entry
{
    DateTime todayDate = DateTime.Now;
    public string _date;
    public string _entry = "";
    public string _fullEntry = "";

    public Entry()
    {
        _date = todayDate.ToString();
    }

    public string Display()
    {
        Prompt RanPrompt = new Prompt();
        string prom = RanPrompt.DisplayRandomPrompt();
        Console.Write("> ");
        _entry = Console.ReadLine();
        _fullEntry = "Date: " + _date + " - Prompt: " + prom  +"\n"+  _entry;
        
        return _fullEntry;
    }

    public void PrintEntry()
    {
        Console.WriteLine(_fullEntry);
    }

}