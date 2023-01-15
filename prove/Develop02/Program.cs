using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _myJournal = new Journal();
        _myJournal.AddEntry();
        _myJournal.DisplayEntries();
        _myJournal.AddEntry();
        _myJournal.DisplayEntries();
        
        
    }
}