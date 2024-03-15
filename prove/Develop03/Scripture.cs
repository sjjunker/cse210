public class Scripture
{
    //Member variables
    private Reference _reference;
    private List<Word> _words;
    private List<char> _firstLetters;

    //Constructor
    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _words = new List<Word>();

        //Make an array of strings from the scripture
        string[] words = scripture.Split(" ");

        //Set each string to a word and add to _words list
        foreach (string word in words)
        {
            Word newWord = new Word(word, false);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0; i < numberToHide; i++)
        {
            Random index = new Random();
            _words[index.Next(0, _words.Count)].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        int currentIndex = 0;
        int lastIndex = _words.Count;

        foreach(Word word in _words)
        {
            //Get the word's text
            text += word.GetDisplayText();

            //Check it isn't the last word and add a space
            if(!(currentIndex == lastIndex))
            {
                text += " ";
                currentIndex++;
            }
        }

        //Add scripture reference and return text
        text += $" {_reference.GetDisplayText()}";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool hidden = true;

        //Try to find a word that isn't hidden. If there is, set hidden to false.
        foreach(Word word in _words)
        {
            if (!word.IsHidden(word))
            {
                hidden = false;
            }
        }

        return hidden;
    }

    //**********Creativity Set and Display Hints
    private void SetHints()
    {
        _firstLetters = new List<char>();
        foreach(Word word in _words)
        {
            if(word.IsHidden(word))
            {
                _firstLetters.Add(word.GetFirstLetter());
            }
        }
    }

    public string GetHintText() 
    {
        SetHints();

        string text = "The first letter of each hidden word is:";

        for (int i = 0; i < _firstLetters.Count; i++)
        {
            text += $" {_firstLetters[i]}";
        }

        return text;
    }
}