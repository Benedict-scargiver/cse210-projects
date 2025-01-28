public class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _startVerse = 0;
    private int _endVerse = 0;

    // Constructor
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Method to get the display text of the reference
    public string GetDisplayText()
    {
        // Assuming the format is "<Book> <Chapter>:<StartVerse>-<EndVerse>"
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}