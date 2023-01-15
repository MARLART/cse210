public class Journal
{
    List<Entry> _allEntries = new List<Entry>();
    public Journal()
    {

    }
    public void AddEntry()
    {
        Entry _newEntry = new Entry();
        _newEntry.Display();
        _newEntry.PrintEntry();
        _allEntries.Add(_newEntry);


        foreach (Entry entry in _allEntries)
        {
            Console.WriteLine(entry);
        }
        

    }

    public void DisplayEntries()
    {
        int _num = _allEntries.Count();
       
    }
}