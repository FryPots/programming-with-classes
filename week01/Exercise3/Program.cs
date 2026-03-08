using System;

class Program
{
    static void Main(string[] args) {
        string play = "yes";
        while (play == "yes") {
            
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            

            int guess;
            int correct = 0;
            int tries = 0;

            while (correct == 0)  {

                Console.WriteLine("Guess a number between 1 and 100:");
                guess = int.Parse(Console.ReadLine());
                tries = tries + 1;
                if (guess < number) {
                    Console.WriteLine("Too low! Try again.");
                }

                else if (guess > number) {
                    Console.WriteLine("Too high! Try again.");
                }
                
                else {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    Console.WriteLine($"You got it in {tries} tries.");
                    correct = 1;
                }
            }

            Console.WriteLine("Do you want to play again? (yes/no) ");
            play = Console.ReadLine();
        }
    
    }
}