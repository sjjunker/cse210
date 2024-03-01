using System;

class Program
{
    static void Main(string[] args)
    {
        //Set the Game State
        string playAgain = "yes";

        while (playAgain == "yes") {

            //Set the magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            //User guess
            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());
            int numberOfGuesses = 1;

            while (userGuess != magicNumber) {
                //Provide feedback
                if (userGuess > magicNumber) 
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

                //User guess
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                numberOfGuesses++;
            }

            //Display Results
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Number of Guesses: {numberOfGuesses}");

            //Ask to play again
            Console.Write("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
}