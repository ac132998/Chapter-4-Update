using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you choose rock - r, paper - p, or scissors - s?");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(1,3);
            /* computer choice 1 = rock
             * computer choice 2 = paper
             * computer choice 3 = scissors*/

            if (computerChoice == 1)
            {
                if (userChoice == "r")
                {
                    Console.WriteLine("The computer chose rock!");
                    Console.WriteLine("Its a tie!");
                }
                else if (userChoice == "p")
                {
                    Console.WriteLine("The computer chose rock!");
                    Console.WriteLine("You win!");
                }
                else if (userChoice == "s")
                {
                    Console.WriteLine("The Computer chose rock!");
                    Console.WriteLine("You lose :( ");
                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "r")
                {
                    Console.WriteLine("The computer chose paper!");
                    Console.WriteLine("You lose :( ");
                }
                else if (userChoice == "p")
                {
                    Console.WriteLine("The computer chose paper!");
                    Console.WriteLine("It a tie!");
                }
                else if (userChoice == "s")
                {
                    Console.WriteLine("The Computer chose paper!");
                    Console.WriteLine("You win! ");
                }
            }

            else if (computerChoice == 3)
            {
                if (userChoice == "r")
                {
                    Console.WriteLine("The computer chose scissors!");
                    Console.WriteLine("You win! ");
                }
                else if (userChoice == "p")
                {
                    Console.WriteLine("The computer chose scissors!");
                    Console.WriteLine("You lose :( ");
                }
                else if (userChoice == "s")
                {
                    Console.WriteLine("The Computer chose scissors!");
                    Console.WriteLine("It's a tie!");
                }

            }


        }
    }
}
