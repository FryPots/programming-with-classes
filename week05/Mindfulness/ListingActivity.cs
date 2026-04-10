public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?",
    };

    private Random _rand = new Random();

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\n" + GetRandomPrompt());
        Console.WriteLine("\nStart in...");
        ShowCountDown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
}