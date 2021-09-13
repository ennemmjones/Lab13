using System;
using System.Collections.Generic;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            
               
                RandomPlayer random = new RandomPlayer("Edward Nigma");
                RockPlayer rock = new RockPlayer("Dwayne Johnson");
                            
                RPSApp.Battle(random, rock);
                
            



        }
        
    }
}
