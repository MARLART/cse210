public class Journal
{
    List<Entry> _allEntries = new List<Entry>();
    public Journal()
    {

    }
    public List<Entry> AddEntry()
    {
        Entry _newEntry = new Entry();
        _newEntry.Display();
        _newEntry.PrintEntry();
        _allEntries.Add(_newEntry);
        Console.WriteLine(_allEntries.Count());
        return _allEntries;
    }

    public void DisplayEntries()
    {
        Console.WriteLine(_allEntries.Count());

        foreach (Entry entry in _allEntries)
        {
            Console.WriteLine(entry);
        }
       
    }
}