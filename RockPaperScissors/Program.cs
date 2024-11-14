using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "Rock", "Scissors", "Paper" };
            Random random = new Random();
            string playAgain;

            Console.WriteLine("Welcome to the 'Rock, Paper, Scissors' game!");

            do
            {
                Console.WriteLine("\nChoose: 1 - Rock, 2 - Scissors, 3 - Paper");
                Console.Write("Your choice: ");

                if (int.TryParse(Console.ReadLine(), out int playerChoice) && playerChoice >= 1 && playerChoice <= 3)
                {
                    int computerChoice = random.Next(1, 4);
                    string playerMove = options[playerChoice - 1];
                    string computerMove = options[computerChoice - 1];

                    Console.WriteLine($"\nYou chose: {playerMove}");
                    Console.WriteLine($"Computer chose: {computerMove}");

                    if (playerChoice == computerChoice)
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    else if ((playerChoice == 1 && computerChoice == 2) ||
                             (playerChoice == 2 && computerChoice == 3) ||
                             (playerChoice == 3 && computerChoice == 1))
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("Computer wins!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }

                Console.Write("\nDo you want to play again? (yes/no): ");
                playAgain = Console.ReadLine().ToLower();

            } while (playAgain == "yes");

            Console.WriteLine("Thanks for playing! Press any key to exit.");
            Console.ReadKey();
        }
    }
}