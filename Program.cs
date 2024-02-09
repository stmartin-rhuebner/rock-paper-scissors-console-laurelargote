using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic;

public class Program
{
    enum Move {
        Invalid = -1,
        Rock,
        Paper,
        Scissors,
        Spock,
        Lizard,
        Quit
    }
    const int MinMove = (int)Move.Rock;
    const int MaxMove = (int)Move.Lizard;

    enum Outcome {
        Draw = 0,
        UserWin = -1,
        ComputerWin = 1
    }
    
        public static void Main()
    {
        int seed = (int)DateTime.Now.Ticks;
        Random random = new Random();
        int draws = 0;
        int losses = 0;
        int wins = 0;
        
        do
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }
            Move userMove;
            
            do
            {
                Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors, [sp]ock, [l]izard, or [q]uit.");
                string input = Console.ReadLine().ToLower();
                if (input == "r" || input == "rock")
                {
                    userMove = Move.Rock;
                }
                else if (input == "p" || input == "paper")
                {
                    userMove = Move.Paper;
                }
                else if (input == "s" || input == "scissors")
                {
                    userMove = Move.Scissors;
                }
                else if (input == "sp" || input == "spock")
                {
                    userMove = Move.Spock;
                }
                else if (input == "l" || input == "lizard")
                {
                    userMove = Move.Lizard;
                }
                else if (input == "q" || input == "quit")
                {
                    userMove = Move.Quit;
                }
            
                else
                {
                    Console.WriteLine("Invalid entry");
                    userMove = Move.Invalid; 
                }
            }while (userMove == Move.Invalid);

            if (userMove == Move.Quit) return;

            Move computerMove = (Move)random.Next(MinMove,MaxMove);

            Outcome outcome = Outcome.Draw; 
            if (userMove == Move.Rock) 
            {
                if (computerMove == Move.Paper || computerMove == Move.Spock) 
                {
                    outcome = Outcome.ComputerWin; 
                }
                else if (computerMove == Move.Scissors || computerMove == Move.Lizard) 
                {
                    outcome = Outcome.UserWin; 
                }
                else if (computerMove == Move.Rock)
                {
                    outcome = Outcome.Draw; 
                }
            }
            else if (userMove == Move.Paper)
            {
                if (computerMove == Move.Rock || computerMove == Move.Lizard)
                {
                    outcome = Outcome.UserWin;
                }
                else if (computerMove == Move.Scissors || computerMove == Move.Spock)
                {
                    outcome = Outcome.ComputerWin;
                }
                else if (computerMove == Move.Paper)
                {
                    outcome = Outcome.Draw;
                }
                }
                else if (userMove == Move.Scissors)
                {
                    if (computerMove == Move.Rock || computerMove == Move.Spock)
                    {
                        outcome = Outcome.ComputerWin;
                    }
                    else if (computerMove == Move.Paper || computerMove == Move.Lizard)
                    {
                        outcome = Outcome.UserWin;
                    }
                    else if (computerMove == Move.Scissors)
                    {
                        outcome = Outcome.Draw;
                    }
                }
                else if (userMove == Move.Spock)
                {
                    if (computerMove == Move.Rock || computerMove == Move.Scissors)
                    {
                        outcome = Outcome.UserWin;
                    }
                    else if (computerMove == Move.Paper || computerMove == Move.Lizard)
                    {
                        outcome = Outcome.ComputerWin;
                    }
                    else if (computerMove == Move.Spock)
                    {
                        outcome = Outcome.Draw;
                    }
                }
                else if (userMove == Move.Lizard)
                {
                    if (computerMove == Move.Spock || computerMove == Move.Paper)
                    {
                        outcome = Outcome.UserWin;
                    }
                    else if (computerMove == Move.Rock || computerMove == Move.Scissors)
                    {
                        outcome = Outcome.ComputerWin;
                    }
                    else if (computerMove == Move.Lizard)
                    {
                        outcome = Outcome.Draw;
                    }
                }

                switch (userMove)
                {
                    case Move.Rock:
                        Console.Write("You chose rock ");
                        break;
                    case Move.Paper:
                        Console.Write("You chose paper ");
                        break;
                    case Move.Scissors:
                        Console.Write("You chose scissors ");
                        break;
                    case Move.Spock:
                        Console.Write("You chose spock ");
                        break;
                    case Move.Lizard:
                        Console.Write("You chose lizard ");
                        break;
                }

                switch (computerMove)
                {
                    case Move.Rock:
                        Console.Write("and computer chose rock.");
                        break;
                    case Move.Paper:
                        Console.Write("and computer chose paper.");
                        break;
                    case Move.Scissors:
                        Console.Write("and computer chose scissors.");
                        break;
                    case Move.Spock:
                        Console.Write("and computer chose spock.");
                        break;
                    case Move.Lizard:
                        Console.Write("and computer chose lizard.");
                        break;
                }

        
            switch (outcome)
            {
                case Outcome.Draw:
                    Console.WriteLine("The game was a draw.");
                    draws++;
                    break;
                case Outcome.ComputerWin:
                    Console.WriteLine("You lose.");
                    losses++;
                    break;
                case Outcome.UserWin:
                    Console.WriteLine("You win.");
                    wins++;
                    break;
                default:
                    Console.WriteLine("Error, invalid outcome");
                    break;
            }

            Console.Write("Score: {0} wins, {1} losses, {2} draws.", wins, losses, draws);
            Console.ReadLine();
        }
        while(true);
    }
    
}
