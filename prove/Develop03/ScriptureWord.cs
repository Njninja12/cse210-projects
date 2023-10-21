using System;

class ScriptureWord
{
    private string word;
    private int index;

    public string Word
    {
        get { return word; }
        private set { word = value; }
    }

    public int Index
    {
        get { return index; }
        private set { index = value; }
    }

    public ScriptureWord(string word, int index)
    {
        Word = word;
        Index = index;
    }
}
