using System.IO;
using System.Text;
public class Journal
{
    string filePath = "savedJournal.csv";
    List<Entry> _allEntries = new List<Entry>();
    public Journal()
    {

    }
    public void AddEntry()
    {
        Entry _newEntry = new Entry();
        _newEntry.Display();

        _allEntries.Add(_newEntry);
    }

    public void DisplayEntries()
    {
        ReadFromCSV();
        
        int _num = _allEntries.Count();

        foreach (Entry entry in _allEntries)
        {
             entry.PrintEntry();
        }

              
    }

    public void WriteToCSV()
    {
        //StringBuilder builder = new StringBuilder();

        foreach (Entry entry in _allEntries)
        {
           entry.SaveFullEntry();
        }
        
       
    }

    public void ReadFromCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (! streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split('|');

            Console.WriteLine("{0}", values[0]);
        }
    }
}