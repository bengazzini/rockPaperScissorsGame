internal class Program
{
    private static void Main(string[] args)
    {
        int winCountUser = 0;
        int winCountComputer = 0;
        string[] computerHand = new string[] { "Rock", "Paper", "Scissors" };
        Random random = new Random();
        bool keepPlaying = true;

        Console.WriteLine("Welcome! Let's play some ROCK, PAPER, SCISSORS!!! ");
        Console.WriteLine("Type Rock, Paper, or Scissors to begin!");

        do
        {
            int randomIndex = random.Next(computerHand.Length);
            string computerTurn = computerHand[randomIndex].ToLower();
            string userTurn = Console.ReadLine().ToLower();
            Console.WriteLine(computerTurn);
            
            if (userTurn == "rock" && computerTurn == "scissors" || userTurn == "paper" && computerTurn == "rock" || userTurn == "scissors" && computerTurn == "paper")
            {
                winCountUser++;
                Console.WriteLine($"You have won this round. Win Count: {winCountUser} Lose Count {winCountComputer}.");
            }
            else if (computerTurn == "rock" && userTurn == "scissors" || computerTurn == "paper" && userTurn == "rock" || computerTurn == "scissors" && userTurn == "paper")
            {
                winCountComputer++;
                Console.WriteLine($"You have lost this round. Win Count: {winCountUser} Lose Count {winCountComputer}.");
            }
            else if(computerTurn == userTurn)
            {
                Console.WriteLine("Draw! Try again.");
            }
                    if (winCountUser == 3)
            {
                keepPlaying = false;
                Console.WriteLine("Congratulations, you have won!");
            }
            if(winCountComputer == 3)
            {
                keepPlaying = false;
                Console.WriteLine("Congratulations, you have lost!");
            }
        }
        while(winCountUser <= 3 && keepPlaying == true || winCountComputer <= 3 && keepPlaying == true);
    
    }
}