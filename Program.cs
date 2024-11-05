using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            string player;
            string computer;
            bool playAgain = true;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Please Choose ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                }
                switch(rnd.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Its a TIE");
                        }
                        else if(computer == "PAPER")
                        {
                            Console.WriteLine("YOU LOSE");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU WIN");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Its a TIE");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU WIN");
                        }
                        else
                        {
                            Console.WriteLine("Its a TIE");
                        }
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? (Y/N)");
                string response = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for Playing");
        }
    }
}
