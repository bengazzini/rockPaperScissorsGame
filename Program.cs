internal class Program
{
    private static void Main(string[] args)
    {
        int winCountUser = 0;
        int winCountComputer = 0;
        string[] computerHand = new string[] { "Rock", "Paper", "Scissors" };
        Random random = new Random();


        Console.WriteLine("GamesMaster: Welcome! Let's play some ROCK, PAPER, SCISSORS!!! ");
        Console.WriteLine("GamesMaster: Type Rock, Paper, or Scissors to begin!");

        do
        {
            int randomIndex = random.Next(computerHand.Length);
            string computerTurn = computerHand[randomIndex];
            string userTurn = Console.ReadLine();
            Console.WriteLine("GamesMaster: " + computerTurn);
            
            if (userTurn == "Rock" && computerTurn == "Scissors" || userTurn == "Paper" && computerTurn == "Rock" || userTurn == "Scissors" && computerTurn == "Paper")
            {
                winCountUser++;
                Console.WriteLine($"You have won this round. Win Count: {winCountUser} Lose Count {winCountComputer}.");
            }
            else if (computerTurn == "Rock" && userTurn == "Scissors" || computerTurn == "Paper" && userTurn == "Rock" || computerTurn == "Scissors" && userTurn == "Paper")
            {
                winCountComputer++;
                Console.WriteLine($"You have lost this round. Win Count: {winCountUser} Lose Count {winCountComputer}.");
            }
            else if(computerTurn == userTurn)
            {
                Console.WriteLine("Draw! Try again.");
            }
        }
        while (winCountUser < 3 || winCountComputer < 3);
        if (winCountUser == 3)
        {
            Console.WriteLine("Congrats, you are a true winner!");
            Environment.Exit(0);
        }
        if(winCountComputer == 3)
        {
            Environment.Exit(0);
        }
    }
}