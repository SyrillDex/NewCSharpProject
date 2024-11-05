using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int guesses;
            int answer;
            int number;
            int min = 1;
            int max = 100;
            bool playAgain = true;
            String response;

            while (playAgain)
            {
                answer = 0;
                guesses = 0;
                number = rnd.Next(min, max + 1);
                response = "";

                while(answer != number)
                {
                    Console.Write("Guess a number from " + min + " - " + max + " : ");
                    answer = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Guess : " + answer);

                    if(answer > number)
                    {
                        Console.WriteLine(" Hint : Lower!");
                    }
                    else if (answer < number)
                    {
                        Console.WriteLine(" Hint : Higher");
                        
                    }
                    Console.WriteLine();
                    guesses++;
                }
                Console.WriteLine();
                Console.WriteLine("The correct answer is " + number);
                Console.WriteLine("YOU WIN!!");
                Console.WriteLine("Number of guesses: " + guesses);
                Console.WriteLine();

                Console.WriteLine("Would you like to play again? (Y/N)");
                response = Console.ReadLine().ToUpper();
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
            Console.WriteLine("Thanks for playing");

        }
    }
}
