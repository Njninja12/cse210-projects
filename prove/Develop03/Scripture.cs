class Scripture
{
    private ScriptureReference _reference;
    private string _text;
    private string[] _words;
    private Random _random;

    public ScriptureReference Reference
    {
        get { return _reference; }
        private set { _reference = value; }
    }

    public string Text
    {
        get { return _text; }
        private set { _text = value; }
    }

    public string[] Words
    {
        get { return _words; }
        private set { _words = value; }
    }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = text.Split(' ');
        _random = new Random();
    }

    public string[] HideWords(List<ScriptureWord> _hiddenWords)
    {
        var _visibleWords = new string[_words.Length];
        for (int i = 0; i < _words.Length; i++)
        {
            if (_hiddenWords.Any(word => word.Index == i))
            {
                _visibleWords[i] = "_____";
            }
            else
            {
                _visibleWords[i] = _words[i];
            }
        }
        return _visibleWords;
    }

    public ScriptureWord GetRandomUnhiddenWord(List<ScriptureWord> _hiddenWords)
    {
        var _unhiddenWords = _words
            .Select((word, index) => new ScriptureWord(word, index))
            .Where(word => !_hiddenWords.Contains(word))
            .ToList();

        return _unhiddenWords[_random.Next(0, _unhiddenWords.Count)];
    }
}
