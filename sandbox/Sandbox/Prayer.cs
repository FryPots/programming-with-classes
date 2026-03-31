using System;

class Prayer
{
    private string _text;
    public Prayer(string text)
    {
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine(_text);
    }
}