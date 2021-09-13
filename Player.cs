using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public enum RPS
    {
        Rock,
        Paper,
        Scissors
    }
    public interface IPlayer
    {
        string Name { get; set; }

        public RPS GenerateRPS();
        
    }
    public class RockPlayer: IPlayer
    {
        public string Name { get; set; }
        public RPS GenerateRPS()
        {
            return RPS.Rock;           
        }
        public RockPlayer(string name)
        {
            Name = name; 
        }
    }

    public class RandomPlayer : IPlayer
    {
        public string Name { get; set; }
        public RPS GenerateRPS()
        {               
            Random rnd = new Random();
            return (RPS)rnd.Next(0, 3);            
        }
        public RandomPlayer(string name)
        {
            Name = name;
        }

    }
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        public RPS GenerateRPS()
        {
            bool exit;
            string userInput;

            do
            {
                Console.Write("\nRock, paper, or scissors? (R/P/S): ");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "r" || userInput == "p" || userInput == "s")
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("please enter valid selection");                    
                    exit = true;
                }
            } while (exit);

            switch (userInput)
            {
                case "r":
                    return RPS.Rock;
                case "p":
                    return RPS.Paper;
                case "s":
                    return RPS.Scissors;   
                default:
                    return RPS.Rock;                    
            }          
        }
        public HumanPlayer(string name)
        {
            Name = name;
        }
    }
    
}
