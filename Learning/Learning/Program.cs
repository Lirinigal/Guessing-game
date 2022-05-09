using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Liri";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (secretWord != guess && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
               
            }
            if (outOfGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("You Win!");
            }

            Console.ReadLine();

        }
    }
}
