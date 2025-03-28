﻿
internal class Program
{
    private static void Main(string[] args)
    {
        int winCountUser = 0;
        int winCountComputer = 0;
        string[] computerHand = new string[] { "Rock", "Paper", "Scissors" };
        Random random = new Random();
        bool keepPlaying = true;
        string userInput = "";
        
        PlayGame();

        do
        {
            int randomIndex = random.Next(computerHand.Length);
            string computerTurn = computerHand[randomIndex].ToLower();
            Console.Write("You: ");
            string userTurn = Console.ReadLine().ToLower();
            Console.WriteLine($"Computer: {computerTurn}");
            if(userTurn != "rock".ToLower() && userTurn != "paper".ToLower() && userTurn != "scissors".ToLower())
            {
                Console.WriteLine("Input is not recognized. Please type rock, paper, or scissors.");
            }

            if (userTurn == "rock" && computerTurn == "scissors" || userTurn == "paper" && computerTurn == "rock" || userTurn == "scissors" && computerTurn == "paper")
            {
                winCountUser++;
                Console.WriteLine($"Win Count: {winCountUser} Loss Count {winCountComputer}.");
            }
            else if (computerTurn == "rock" && userTurn == "scissors" || computerTurn == "paper" && userTurn == "rock" || computerTurn == "scissors" && userTurn == "paper")
            {
                winCountComputer++;
                Console.WriteLine($"Win Count: {winCountUser} Lose Count {winCountComputer}.");
            }
            else if(computerTurn == userTurn)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Draw! Try again.");
                Console.ResetColor();
            }
                if (winCountUser == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations, you have won!");
                Console.ResetColor();
                Console.WriteLine("Would you like to play again? yes/no");
                userInput = Console.ReadLine();
                if(userInput == "yes")
                {
                    winCountUser = 0;
                    winCountComputer = 0;
                    keepPlaying = true;
                    PlayGame();
                }
                if(userInput == "no")
                {
                    keepPlaying = false;
                }
            }
            if(winCountComputer == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Congratulations, you have lost!");
                Console.ResetColor();
                Console.WriteLine("Would you like to play again? yes/no");
                userInput = Console.ReadLine();
                if(userInput == "yes")
                {
                    winCountUser = 0;
                    winCountComputer = 0;
                    keepPlaying = true;
                    PlayGame();
                }

                if(userInput == "no")
                {
                    keepPlaying = false;
                }
            }
        }
        while(winCountUser <= 3 && keepPlaying == true || winCountComputer <= 3 && keepPlaying == true);   
    }

    static void PlayGame()
    {
        Console.Clear();
        Console.WriteLine("Welcome! Let's play some ROCK, PAPER, SCISSORS!!! ");
        Console.WriteLine("Type Rock, Paper, or Scissors to begin!");
    }
}