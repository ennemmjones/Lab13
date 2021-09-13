using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class RPSApp
    { 
        public  static IPlayer SelectOpponent(RandomPlayer random, RockPlayer rock)
        {
            string rockShort = rock.Name.Substring(0, 1).ToLower();
            string randomShort = random.Name.Substring(0, 1).ToLower();
            string userInput;
            bool exit;

            do
            {
                Console.Write($"\nWould you like to play against {random.Name} or {rock.Name} ({randomShort}/{rockShort})?: ");
                userInput = Console.ReadLine().ToLower();
                if (userInput == rockShort || userInput == randomShort)
                {
                    exit = false;
                }                
                else
                {
                    Console.WriteLine("please enter valid opponent");                    
                    exit = true;
                }
            } while (exit);
            if (userInput == rockShort)
            {
                return rock;
            }
            else
            {
                return random;
            }
        }
        public static void Battle(RandomPlayer random, RockPlayer rock)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.Write("Enter your name: ");
           
            HumanPlayer humanPlayer = new HumanPlayer(Console.ReadLine());
            IPlayer computerPlayer = SelectOpponent(random, rock);

            int humanWin = 0;
            int computerWin = 0;
            int draw = 0;
            bool exit;
            do
            {
                var humanRPS = humanPlayer.GenerateRPS();
                var computerRPS = computerPlayer.GenerateRPS();

                Console.WriteLine($"\n{humanPlayer.Name}: {humanRPS}");
                Console.WriteLine($"{computerPlayer.Name}: {computerRPS}");
                switch (humanRPS)
                {
                    case RPS.Rock:
                        if (computerRPS == RPS.Rock)
                        {
                            Console.WriteLine($"draw!");
                            draw++;
                        }
                        else if (computerRPS == RPS.Paper)
                        {
                            Console.WriteLine($"{computerPlayer.Name} wins!");
                            computerWin++;
                        }
                        else
                        {
                            Console.WriteLine($"{humanPlayer.Name} wins!");
                            humanWin++;
                        }
                        break;

                    case RPS.Paper:
                        if (computerRPS == RPS.Rock)
                        {
                            Console.WriteLine($"{humanPlayer.Name} wins!");
                            humanWin++;
                        }
                        else if (computerRPS == RPS.Paper)
                        {
                            Console.WriteLine($"draw!");
                            draw++;
                        }
                        else
                        {
                            Console.WriteLine($"{computerPlayer.Name} wins!");
                            computerWin++;
                        }
                        break;

                    case RPS.Scissors:
                        if (computerRPS == RPS.Rock)
                        {
                            Console.WriteLine($"{computerPlayer.Name} wins!");
                            computerWin++;
                        }
                        else if (computerRPS == RPS.Paper)
                        {
                            Console.WriteLine($"{humanPlayer.Name} wins!");
                            humanWin++;
                        }
                        else
                        {
                            Console.WriteLine($"draw!");
                            draw++;
                        }
                        break;
                    
                }
                Console.WriteLine($"Current score: {humanPlayer.Name}: {humanWin}, {computerPlayer.Name}: {computerWin}, Draw: {draw}");
                Console.Write("\nPlay again? (y/n): ");
                if (Console.ReadLine().ToLower() != "y") 
                {
                    exit = false;
                }
                else
                {
                    exit = true;
                }
                      
                    
            } while (exit);

            



        }
    }
}
