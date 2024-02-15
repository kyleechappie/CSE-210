public class Reference
{
    private int startVerse;
    private int endVerse;

    public Reference(int startVerse, int endVerse)
    {
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        if (startVerse == endVerse)
        {
            return $"{startVerse}";
        }
        else
        {
            return $"{startVerse}-{endVerse}";
        }
    }
}
