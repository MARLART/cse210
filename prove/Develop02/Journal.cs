using System.IO;
using System.Text;
public class Journal
{
    string filePath = "savedJournal.csv";
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

    public void WriteToCSV()
    {
        StringBuilder builder = new StringBuilder();

        string text1 = "Text1";
        string text2 = "Text2";

        builder.AppendLine(string.Format("{0}|{1}", text1, text2));

        File.WriteAllText(filePath, builder.ToString());
    }

    public void ReadFromCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (! streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split();

            Console.WriteLine("{0}", values[0]);
        }
    }
}