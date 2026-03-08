using System;

class Program
{
    static void Main(string[] args) {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = -1;
        List<int> numbers = new List<int>();
        while (input != 0)  {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }   

        int sum = 0;
        int greater = 0;
        for (int index = 0; index < numbers.Count; index++) {
            int number = numbers[index];
            sum += number;
            if (greater < number) {
                greater = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / ((float)numbers.Count - 1)}");
        Console.WriteLine($"The greatest number is: {greater}");
    }
}