class Reference
{
    string _book = "";
    string _chapter = "";
    string _verse = "";
    string _endVerse = "";
    string _reference = "";

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    

    public void Show()
    {
        if(!(_endVerse == ""))
        {
            _reference = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }
        else
        {
            _reference = $"{_book} {_chapter}:{_verse} ";
        }

        Console.WriteLine(_reference);
    }
    
}