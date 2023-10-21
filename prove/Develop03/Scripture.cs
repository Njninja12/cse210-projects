using System;

class Scripture
{
    public ScriptureReference Reference { get; }
    public string Text { get; }
    public string[] Words { get; }
    private Random random;

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