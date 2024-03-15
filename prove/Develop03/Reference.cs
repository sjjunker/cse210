public class Reference
{
    //Member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //Method
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter.ToString()}:{_verse.ToString()}";
        }
        else 
        {
            return $"{_book} {_chapter.ToString()}:{_verse.ToString()}-{_endVerse.ToString()}";
        }
    }
}