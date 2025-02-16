public class Reference
{
    private string _word;
    private string _book;
    private int _chapter;
    private int _verseBeginning;
    private int _verseEnd;
    private List<Word> _words = new List<Word>();

    public List<Word> getWords()
    {
        return _words;
    }

    public Reference()
    {

    }

    public Reference(string book, int chapter, int verseBeginning, int verseEnd, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseBeginning = verseBeginning;
        _verseEnd = verseEnd;

        foreach (string strWord in text.Split(' '))
        {
            _words.Add(new Word(strWord));
        }
    }

    public Reference(string book, int chapter, int verseBeginning, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseBeginning = verseBeginning;
        foreach (string strWord in text.Split(' '))
        {
            _words.Add(new Word(strWord));
        }
    }

    public void Display()
    {
        foreach (Word word in _words)
        {
            if (word._wordHidden == false)
            {
                Console.Write(word._wordText + " ");
            }
            else
            {
                int wordLength = word._wordText.Length;

                for (int i = 0; i < wordLength; i++)
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
        }
    }

    public void DisplayFormattedReference()
    {
        if (_verseEnd == 0)
        {
            Console.Write($"{_book} {_chapter}:{_verseBeginning} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_verseBeginning}-{_verseEnd} ");
        }
    }

    public void HideWords()
    {
        HideRandomWord();
        HideRandomWord();
        HideRandomWord();
    }

    public void HideRandomWord()
    {
        while (_words.Any(x => !x._wordHidden))
        {
            Random random = new Random();
            int randomNumber = random.Next(0, _words.Count);

            Word word = _words[randomNumber];
            if (!word._wordHidden)
            {
                word.SetHidden();
                break;
            }
        }
    }
}