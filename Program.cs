using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic;

public class Program
{
    const int Rock = 0;
    const int Paper = 1;
    const int Scissors = 2;
    const int Quit = 3;
    const int Invalid = -1;

    //outcomes
    const int Draw = 0;
    const int UserWin = -1;
    const int ComputerWin = 1;
        public static void Main()
    {
        int seed = (int)DateTime.Now.Ticks;
        Random random = new Random();
        int draws = 0;
        int losses = 0;
        int wins = 0;
        
        do
        {
    
            int userMove;
            
            do
            {
                Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors, or [q]uit.");
                string input = Console.ReadLine().ToLower();
                if (input == "r" || input == "rock")
                {
                    userMove = Rock;
                }
                else if (input == "p" || input == "paper")
                {
                    userMove = Paper;
                }
                else if (input == "s" || input == "scissors")
                {
                    userMove = Scissors;
                }
                else if (input == "q" || input == "quit")
                {
                    userMove = Quit;
                }
            
                else
                {
                    Console.WriteLine("Invalid entry");
                    userMove = Invalid; 
                }
            }while (userMove == Invalid);

            if (userMove == Quit) return;

            int computerMove = random.Next(Rock, Scissors + 1);

            int result = Invalid; 
            if (userMove == Rock) 
            {
                if (computerMove == Paper) 
                {
                    result = ComputerWin; 
                }
                else if (computerMove == Scissors) 
                {
                    result = UserWin; 
                }
                else if (computerMove == Rock)
                {
                    result = Draw; 
                }
            }
            else if (userMove == Paper)
            {
                if (computerMove == Rock)
                {
                    result = UserWin;
                }
                else if (computerMove == Scissors)
                {
                    result = ComputerWin;
                }
                else if (computerMove == Paper)
                {
                    result = Draw;
                }
                }
                else if (userMove == Scissors)
                {
                    if (computerMove == Rock)
                    {
                        result = ComputerWin;
                    }
                    else if (computerMove == Paper)
                    {
                        result = UserWin;
                    }
                    else if (computerMove == Scissors)
                    {
                        result = Draw;
                    }
                }

                switch (userMove)
                {
                    case Rock:
                        Console.Write("You chose rock ");
                        break;
                    case Paper:
                        Console.Write("You chose paper ");
                        break;
                    case Scissors:
                        Console.Write("You chose scissors ");
                        break;
                }

                switch (computerMove)
                {
                    case Rock:
                        Console.Write("and computer chose rock.");
                        break;
                    case Paper:
                        Console.Write("and computer chose paper.");
                        break;
                    case Scissors:
                        Console.Write("and computer chose scissors.");
                        break;
                }

        
            switch (result)
            {
                case Draw:
                    Console.WriteLine("The game was a draw.");
                    draws++;
                    break;
                case ComputerWin:
                    Console.WriteLine("You lose.");
                    losses++;
                    break;
                case UserWin:
                    Console.WriteLine("You win.");
                    wins++;
                    break;
                default:
                    Console.WriteLine("Error, invalid outcome");
                    break;
            }

            Console.Write("Score: {0} wins, {1} losses, {2} draws.", wins, losses, draws);
            Console.WriteLine("User: {0} vs Computer: {1}", userMove, computerMove);
        }
        while(true);
    }
    
}
