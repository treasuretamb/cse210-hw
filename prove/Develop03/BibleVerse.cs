class ScriptureWord
{
    public int Index { get; }
    public string Value { get; }
    public bool IsHidden { get; set; }

    public ScriptureWord(int index, string value)
    {
        Index = index;
        Value = value;
        IsHidden = false;
    }
}