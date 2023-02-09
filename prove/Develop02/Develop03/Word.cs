class Word
{
    private Scripture _scripture; 
    private List<string> _scriptureWords;
    private int _totalWordsHidden = 0;


    public Word(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureWords = new List<string>();
        GetTextToList();
    }

    private void GetTextToList()
    {
        _scriptureWords = _scripture.toString().Split(' ').ToList();
    }

    public void HideWords()
    {
        int _numWordsToHide = 3;
        int _wordsHidden = 0;


       do
       {
        int ranIndex = new Random().Next(0, _scriptureWords.Count()); 
        if(_scriptureWords[ranIndex].Contains('_') == false)
        {
            _scriptureWords[ranIndex]  = new string('_', _scriptureWords[ranIndex].Length);
            _wordsHidden++;
            _totalWordsHidden++; 

            if(_totalWordsHidden < (_scriptureWords.Count()+1) && _totalWordsHidden >= (_scriptureWords.Count()-_numWordsToHide))
            {
                _wordsHidden = 3;
            }

        }


        
       } while (_wordsHidden != _numWordsToHide);

    }

    public string toString()
    {
        return string.Join(" ", _scriptureWords);
    }

    public bool hasWordsLeft()
    {
        bool _fullWords = false;
      

        foreach(string word in _scriptureWords)
        {
            if(word.Contains("_") == false)
            {
                _fullWords = true;
                break;
            }
            
        }
        return _fullWords;
    }
}
