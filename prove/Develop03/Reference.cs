class ScriptureReference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public ScriptureReference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endVerse = verse;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetFormattedReference()
    {
        string reference = $"{book} {chapter}:{startVerse}";

        if (startVerse != endVerse)
            reference += $"-{endVerse}";

        return reference;
    }
}