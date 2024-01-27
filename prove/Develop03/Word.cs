class WordHider
{
    private Scripture scripture;
    private Random random;
    private List<int> hiddenWordIndices;

    public WordHider(Scripture scripture)
    {
        this.scripture = scripture;
        random = new Random();
        hiddenWordIndices = new List<int>();
    }

    public void HideRandomWord()
    {
        int totalWords = scripture.GetFullScripture().Split(' ').Length;
        int wordIndex;

        do
        {
            wordIndex = random.Next(totalWords);
        } while (hiddenWordIndices.Contains(wordIndex));

        hiddenWordIndices.Add(wordIndex);

        // Hide the word at the randomly selected index
        string hiddenScripture = scripture.HideWord(wordIndex);
        Console.WriteLine(hiddenScripture);
    }

    // Check if all the words have been hidden.
    public bool IsScriptureHidden()
    {
        return hiddenWordIndices.Count == scripture.GetFullScripture().Split(' ').Length;
    }
}