class Scripture
{
    private string _reference = "";
    private List<Word> _words = new List<Word>();
    private string _text = "";

    public Scripture(string text)
    {
        _text = text;
        //Word _text = new Word(text);

    }

    private void HideWords()
    {

    }

    public void GetRenderedText()
    {
        Console.WriteLine(_text);
    } 

    private void IsCompletelyHidden()
    {
        
    }
}