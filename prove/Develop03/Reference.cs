class Reference
{
    private string _book, _chapter, _verse, _endVerse, _ref;

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string toString()
    {
        if(_endVerse != "")
        {
            _ref = string.Format("{0} {1}:{2}-{3}", _book, _chapter, _verse, _endVerse);
        }
        else{
            _ref = string.Format("{0} {1}:{2}{3}", _book, _chapter, _verse, _endVerse);
        }

        return _ref;
    }       
}