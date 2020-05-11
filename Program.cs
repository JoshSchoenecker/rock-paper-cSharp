using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // NOTE Game start
            System.Console.WriteLine("Would you like to play Rock Paper Scissors? Y/N");
            string userInput = Console.ReadLine();
            bool playing = userInput.ToLower() == "y";

            // NOTE Data binding
            int wins = 0;
            int losses = 0;
            Random random = new Random();
            int computerChoice = random.Next(1, 3);

            // NOTE Game
            while (playing)
            {
                System.Console.WriteLine("Choose Rock Paper or Scissors");
                string playerChoice = Console.ReadLine();
                // NOTE computer choice Rock
                if (computerChoice == 1)
                {
                    if (playerChoice == "Rock")
                    {
                        System.Console.WriteLine("The computer chose rock as well, It is a tie!");

                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("It's a tie! Do you want to play again? Y/N");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else if (playerChoice == "Paper")
                    {
                        System.Console.WriteLine("The computer chose rock");
                        System.Console.WriteLine("You Win! paper beats rock");

                        wins++;
                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("You won! Do you want to play again? Y/N");
                        string continueGame = Console.ReadLine();
                        if (continueGame.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else if (playerChoice == "Scissors")
                    {
                        System.Console.WriteLine("The computer chose rock");
                        System.Console.WriteLine("You Lose! rock beats scissors");

                        losses++;
                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("You Lost! Do you want to play again? Y/N");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else
                    {
                        System.Console.WriteLine("You must choose Rock, Paper, or Scissors");
                    }
                }
                // NOTE computer choice Paper
                else if (computerChoice == 2)
                {
                    if (playerChoice == "Rock")
                    {
                        System.Console.WriteLine("The computer chose paper");
                        System.Console.WriteLine("You Lose! paper beats rock");

                        losses++;
                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("You Lost! Do you want to play again? Y/N");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else if (playerChoice == "Paper")
                    {
                        System.Console.WriteLine("The computer chose paper as well, It is a tie!");

                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("It's a tie! Do you want to play again? Y/N");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else if (playerChoice == "Scissors")
                    {
                        System.Console.WriteLine("The computer chose paper");
                        System.Console.WriteLine("You Win! scissors beats paper");

                        wins++;
                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("You won! Do you want to play again? Y/N");
                        string continueGame = Console.ReadLine();
                        if (continueGame.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else
                    {
                        System.Console.WriteLine("You must choose Rock, Paper, or Scissors");
                    }
                }
                // NOTE computer choice Scissors
                else if (computerChoice == 3)
                {
                    if (playerChoice == "Rock")
                    {
                        System.Console.WriteLine("The computer chose scissors");
                        System.Console.WriteLine("You Win! rock beats scissors");

                        wins++;
                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("You won! Do you want to play again? Y/N");
                        string continueGame = Console.ReadLine();
                        if (continueGame.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else if (playerChoice == "Paper")
                    {
                        System.Console.WriteLine("The computer chose scissors");
                        System.Console.WriteLine("You Lose! scissors beats paper");

                        losses++;
                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("You Lost! Do you want to play again? Y/N");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else if (playerChoice == "Scissors")
                    {
                        System.Console.WriteLine("The computer chose scissors as well, It is a tie!");

                        System.Console.WriteLine("Wins: " + wins);
                        System.Console.WriteLine("Losses: " + losses);

                        System.Console.WriteLine("It's a tie! Do you want to play again? Y/N");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            computerChoice = random.Next(1, 3);
                            continue;
                        }
                        else
                        {
                            playing = false;
                        }
                        continue;
                    }
                    else
                    {
                        System.Console.WriteLine("You must choose Rock, Paper, or Scissors");
                    }
                }
            }
            // NOTE Game end
            System.Console.WriteLine("Thanks for playing!");

        }
    }
}
