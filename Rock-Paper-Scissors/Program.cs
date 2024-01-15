using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool PlayAgain = true;
            String player;
            String cpu ;

            while (PlayAgain)
            {
                player = "";
                cpu = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("enter ROCK, PAPER, SCISSORS ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                    
                }

                switch (rand.Next(1, 4))
                {
                    case 1:
                        cpu = "ROCK";
                        break;
                    case 2:
                        cpu = "PAPER";
                        break;
                    case 3:
                        cpu = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Cpu: " + cpu);

            }

            Console.ReadKey();
        }
    }
}
