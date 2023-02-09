class Scripture
{
    private Reference _reference;
    private string _text;
    //private string _text = "";

    public Scripture(Reference scriptureRef, string scriptureText)
    {
        _reference  = scriptureRef;
        _text       = scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", _text);
    }


}