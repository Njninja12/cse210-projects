using System;

class Scripture
{
    private ScriptureReference reference;
    private string text;
    private string[] words;
    private Random random;

    public ScriptureReference Reference
    {
        get { return reference; }
        private set { reference = value; }
    }

    public string Text
    {
        get { return text; }
        private set { text = value; }
    }

    public string[] Words
    {
        get { return words; }
        private set { words = value; }
    }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = text.Split(' ');
        random = new Random();
    }

    public string[] HideWords(List<ScriptureWord> hiddenWords)
    {
        var visibleWords = new string[Words.Length];
        for (int i = 0; i < Words.Length; i++)
        {
            if (hiddenWords.Any(word => word.Index == i))
            {
                visibleWords[i] = "_____";
            }
            else
            {
                visibleWords[i] = Words[i];
            }
        }
        return visibleWords;
    }

    public ScriptureWord GetRandomUnhiddenWord(List<ScriptureWord> hiddenWords)
    {
        var unhiddenWords = Words
            .Select((word, index) => new ScriptureWord(word, index))
            .Where(word => !hiddenWords.Contains(word))
            .ToList();

        return unhiddenWords[random.Next(0, unhiddenWords.Count)];
    }
}