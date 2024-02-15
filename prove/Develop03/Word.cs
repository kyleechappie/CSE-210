public class Word
{
    private string content;
    public bool IsHidden { get; private set; }

    public Word(string content)
    {
        this.content = content;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "___" : content;
    }
}
