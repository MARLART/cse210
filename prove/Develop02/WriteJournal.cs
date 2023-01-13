public class WriteJournal
{
    public string _randomPrompt = "";  
    DateTime todayDate = DateTime.Now;
    public string _date;
    public string _entry = "";

    public WriteJournal()
    {
        _date = todayDate.ToString();
    }

    public void Display()
    {
        Prompt RanPrompt = new Prompt();
        RanPrompt.DisplayRandomPrompt();
        Console.Write(_date);
    }

}