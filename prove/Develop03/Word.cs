public class Word
{
    public string _wordText { get; private set; }
    public Boolean _wordHidden { get; private set; }

    public Word(string word)
    {
        _wordText = word;
        _wordHidden = false;
    }
    public void SetHidden()
    { 
        _wordHidden = true;
    }
}