using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);

        string result;

        if (percent >= 90)
        {
            result = "A";
        }
        else if (percent >= 80)
        {
            result = "B";
        }
        else if (percent >= 70)
        {
            result = "C";
        }
        else if (percent >= 60)
        {
            result = "D";
        }
        else
        {
            result = "F";
        }

        Console.WriteLine($"Your grade is {result}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed.");
        }
    }
}