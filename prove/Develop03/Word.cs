using System.ComponentModel.Design;

public class Word
{
    //Member Variables
    private string _word;
    private bool _isHidden;
    private char _firstLetter;

    //Constructor
    public Word (string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
        _firstLetter = word[0];
    }

    //Methods
    public void Hide() 
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden(Word word)
    {
        if(word._isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        if (_isHidden) 
        {
            string underscores = "";

            for(int i = 0; i < _word.Length; i++)
            {
                underscores += "_";
            }

            return underscores;
        }
        else
        {
            return _word;
        }
    }

    public char GetFirstLetter()
    {
        return _firstLetter;
    }
}