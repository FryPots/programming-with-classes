using System;

class Program
{   
    static void Main(string[] args)
    {
        DateTime TIME = DateTime.Now;
        bool run = true;
        string user = "";
        
        PromptGenerator Prompter = new PromptGenerator();
        Journal anJournal = new Journal();
        
        while (run)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            user = Console.ReadLine();
            if (user == "1")
            {
                string prompt = Prompter.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                user = Console.ReadLine();

                Entry myEntry = new Entry();
                myEntry._date = TIME.ToShortDateString(); 
                myEntry._promptText = prompt;
                myEntry._entryText = user;

                anJournal.AddEntry(myEntry);
            } 
            
            else if (user == "2")
            {
                anJournal.DisplayAll();
            }

            else if (user == "3")
            {
                Console.WriteLine("Open... (Do not include the file extention)");
                Console.Write("> ");
                user = Console.ReadLine();
                anJournal.SaveToFile($"{user}.txt");
                
            }

            else if (user == "4")
            {
                Console.WriteLine("Save as... (Do not include the file extention)");
                Console.Write("> ");
                user = Console.ReadLine();
                anJournal.LoadFromFile($"{user}.txt");
            }

            else if (user == "5")
            {
                run = false;
            }

            else
            {
                Console.WriteLine("Invalid input. Try again!");
            }
        }
    } 
}