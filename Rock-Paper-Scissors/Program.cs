using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        private static object cw;

        static void Main(string[] args)
        {
            Random rand = new Random();
            bool PlayAgain = true;
            String player;
            String cpu;
            String response;

            while (PlayAgain)
            {
                player = "";
                cpu = "";
                response = "";


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


                switch (player)
                {
                    case "ROCK":
                        if (cpu == "ROCK")
                        {
                            Console.WriteLine("draw");
                        }
                        else if (cpu == "PAPER")
                        {
                            Console.WriteLine("you lose");
                        }
                        else
                        {
                            Console.WriteLine("you win");
                        }

                        break;
                    case "PAPER":
                        if (cpu == "ROCK")
                        {
                            Console.WriteLine("you win");
                        }
                        else if (cpu == "PAPER")
                        {
                            Console.WriteLine("draw");
                        }
                        else
                        {
                            Console.WriteLine("you lose");
                        }
                        break;
                    case "SCISSORS":
                        if (cpu == "ROCK")
                        {
                            Console.WriteLine("you lose");
                        }
                        else if (cpu == "PAPER")
                        {
                            Console.WriteLine("you win");
                        }
                        else
                        {
                            Console.WriteLine("draw");
                        }
                        break;
                }

                Console.WriteLine("You wan tto play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    PlayAgain = true;
                }
                else if (response == "N")
                {

                    PlayAgain = false;
                }
            }
            Console.WriteLine("thanks for playing");

            Console.ReadKey();
        }
    }
}
