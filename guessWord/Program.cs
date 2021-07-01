using System;

namespace guessWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // SayHi();

            string secretWord = "Right";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();

                if (guess != secretWord)
                {
                    Console.WriteLine("You are wrong. \nKindly try again");
                    Console.ReadLine();
                }

                // guess = Console.ReadLine();

            }

            Console.Write("You won");
            Console.ReadLine();
        }

    }
}
