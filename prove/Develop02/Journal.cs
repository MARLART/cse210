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
       int _num = _allEntries.Count();

        foreach (Entry entry in _allEntries)
        {
             entry.PrintEntry();
        }

              
    }

    public void WriteToCSV()
    {
        StringBuilder builder = new StringBuilder();

        string text1 = "Text1";
        //string text2 = "Text2";

        builder.AppendLine(string.Format("{0}", text1));

        File.WriteAllText(filePath, builder.ToString());
    }

    public void ReadFromCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (! streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split('|');

            Console.WriteLine("{0}|{1}", values[0], values[1]);
            Console.WriteLine("did read from csv work?");
        }
    }
}