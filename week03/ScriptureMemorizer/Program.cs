using System;

class Program
{
    static void Main(string[] args)
    {
        Random ran = new();

        Reference reference = new(book: "Revelation", chapter: 15, verse: 3, endVerse: 4);
        Scripture scripture = new(reference, "And they sing the song of Moses, the servant of God, and the song of the Lamb: 'Great and amazing are your deeds, Lord God the Almighty! Just and true are your ways, King of the nations! Lord, who will not fear and glorify your name? For you alone are holy. All nations will come and worship before you, for your judgments have been revealed.'");

        while (scripture.IsCompletelyHidden() == false)
        {
            scripture.HideRandomWords(10);
            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");     
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}