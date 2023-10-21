class ScriptureReference
{
    private string _reference;

    public string Reference
    {
        get { return _reference; }
        private set { _reference = value; }
    }

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }
}
