class Word
{
    List<string> _individualWords = new List<string>; 
    string _text = "";

    public Word(string text)
    {
        _text = text;

    //.split tells it to seperate words into string
        foreach (string word  in _text.Split())
        {
            _individualWords.Add(word);
        }
    }

    private void Hide()
    {

    }

    private void Show()
    {

    }

    private void IsHidden()
    {

    }

    public void GetRenderedText()
    {
        Console.WriteLine(_individualWords);
    }
}
