using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text) // Constructor
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            Word myWord = new Word(word);
            _words.Add(myWord);
        }
    }
    public void HideRandomWords(int numbersToHide)
    {
        Random ran = new();
        int hiddenCount = 0;

        while (hiddenCount < numbersToHide)
        {
            int ranIndex = ran.Next(0, _words.Count);
            Word myWord = _words[ranIndex];

            int hideTry = 0;
            while (myWord.IsHidden())
            {
                if (hideTry > _words.Count)
                {
                    break;
                }
                ranIndex = ran.Next(0, _words.Count);
                myWord = _words[ranIndex];
                hideTry ++;
            }

            myWord.Hide();
            hiddenCount++;
        }
    }
    public string GetDisplayText() //Getter
    {
        string ret = "";
        foreach(Word word in _words)
        {
            ret += " " + word.GetDisplayText();
        }
        return ret;
    }
    public bool IsCompletelyHidden() //Getter
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden()) //if word in words is not hidden return true
            {
                return false;
            }
        } 
        return true;
    }
}