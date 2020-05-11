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
            Random random = new Random();
            int computerChoice = random.Next(1, 3);
            
            // NOTE Game
            while (playing)
            {
                System.Console.WriteLine("Choose Rock Paper or Scissors");
                string playerChoice = Console.ReadLine();

                if (computerChoice == 1)
                {
                    if (playerChoice == "Rock")
                    {
                        System.Console.WriteLine("The computer chose rock as well, It is a tie!");
                    }
                    else if (playerChoice == "Paper")
                    {
                        System.Console.WriteLine("The computer chose rock");
                        System.Console.WriteLine("You Win! paper beats rock");
                    }
                    else if (playerChoice == "Scissors")
                    {
                        System.Console.WriteLine("The computer chose rock");
                        System.Console.WriteLine("You Lose! rock beats scissors");
                    }
                    else
                    {
                        System.Console.WriteLine("You must choose Rock, Paper, or Scissors");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (playerChoice == "Rock")
                    {
                        System.Console.WriteLine("The computer chose paper");
                        System.Console.WriteLine("You Lose! paper beats rock");
                    }
                    else if (playerChoice == "Paper")
                    {
                        System.Console.WriteLine("The computer chose paper as well, It is a tie!");
                    }
                    else if (playerChoice == "Scissors")
                    {
                        System.Console.WriteLine("The computer chose paper");
                        System.Console.WriteLine("You Win! scissors beats paper");
                    }
                    else
                    {
                        System.Console.WriteLine("You must choose Rock, Paper, or Scissors");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (playerChoice == "Rock")
                    {
                        System.Console.WriteLine("The computer chose scissors");
                        System.Console.WriteLine("You Win! rock beats scissors");
                    }
                    else if (playerChoice == "Paper")
                    {
                        System.Console.WriteLine("The computer chose scissors");
                        System.Console.WriteLine("You Lose! scissors beats paper");
                    }
                    else if (playerChoice == "Scissors")
                    {
                        System.Console.WriteLine("The computer chose scissors as well, It is a tie!");
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
