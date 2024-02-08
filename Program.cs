using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic;

public class Program
{
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
                    userMove = 0;
                }
                else if (input == "p" || input == "paper")
                {
                    userMove = 1;
                }
                else if (input == "s" || input == "scissors")
                {
                    userMove = 2;
                }
                else if (input == "q" || input == "quit")
                {
                    userMove = 3;
                }
            
                else
                {
                    Console.WriteLine("Invalid entry");
                    userMove = -1; //invalid
                }
            }while (userMove == -1);

            if (userMove == 3) return;

            int computerMove = random.Next(0, 3);



            int result = 0; //draw
            if (userMove == 0) //rock
            {
                if (computerMove == 1) //paper
                {
                    result = 1; //computer win
                }
                else if (computerMove == 2) //scissors
                {
                    result = -1; //user win
                }
                else //rock
                {
                    result = 0; //draw
                }
            }
            else if (userMove == 1) //paper
            {
                if (computerMove == 0) //rock
                {
                    result = -1; //computer wins
                }
                else if (computerMove == 2) //scissors
                {
                    result = 1; //computer wins
                }
                else  //paper
                {
                    result = 0;
                }
                }
                else if (userMove == 2) //scissors
                {
                    if (computerMove == 0) //rock
                    {
                        result = 1; //computer win
                    }
                    else if (computerMove == 1) //paper
                    {
                        result = -1; //userwin
                    }
                    else //scissors
                    {
                        result = 0;
                    }
                }

                switch (userMove)
                {
                    case 0:
                        Console.Write("You chose rock ");
                        break;
                    case 1:
                        Console.Write("You chose paper ");
                        break;
                    case 2:
                        Console.Write("You chose scissors ");
                        break;
                }

                switch (computerMove)
                {
                    case 0:
                        Console.Write("and computer chose rock.");
                        break;
                    case 1:
                        Console.Write("and computer chose paper.");
                        break;
                    case 2:
                        Console.Write("and computer chose scissors.");
                        break;
                }

        
            switch (result)
            {
                case 0: //draw
                    Console.WriteLine("The game was a draw.");
                    draws++;
                    break;
                case 1: //computer win
                    Console.WriteLine("You lose.");
                    losses++;
                    break;
                case -1: //user win
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
