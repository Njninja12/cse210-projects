class ScriptureWord
{
    private string _word;
    private int _index;

    public string Word
    {
        get { return _word; }
        private set { _word = value; }
    }

    public int Index
    {
        get { return _index; }
        private set { _index = value; }
    }

    public ScriptureWord(string word, int index)
    {
        Word = word;
        Index = index;
    }
}
