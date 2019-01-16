using System;

namespace GuessingGameSpring19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10.");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You guessed: " + userGuess);

            if (userGuess.Equals("7"))
            {
                Console.WriteLine("You win!");
            } else
            {
                Console.WriteLine("You lost.");
            }
        }
    }
}
