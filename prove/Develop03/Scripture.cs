class Scripture
{
    private ScriptureReference reference;
    private string text;
    private List<ScriptureWord> words;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        this.text = text;

        //Split the scripture text into words and initialize a list of ScriptureWord objects
        words = text.Split(' ')
                    .Select((word, index) => new ScriptureWord(index, word))
                    .ToList();
    }

    public string GetFullScripture()
    {
        return reference.GetFormattedReference() + " - " + text;
    }

    public string HideWord(int wordIndex)
    {
        words[wordIndex].IsHidden = true;

        //Generate the hidden scripture text by replacing hidden words with asterisks
        return string.Join(" ", words.Select(word => word.IsHidden ? new string('*', word.Value.Length) : word.Value));
    }

    public bool IsScriptureHidden()
    {
        //Check if all words in the scripture are hidden 
        return words.All(word => word.IsHidden);
    }
}