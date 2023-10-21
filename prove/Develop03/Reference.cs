using System;

class ScriptureReference
{
    private string reference;

    public string Reference
    {
        get { return reference; }
        private set { reference = value; }
    }

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }
}
