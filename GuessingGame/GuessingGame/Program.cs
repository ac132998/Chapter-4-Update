using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            int min = 1;
            int max = 11;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Console.WriteLine("Enter a number between 1 through 10: ");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry < randomNumber)
            {
                Console.WriteLine("Too Low!");
                Console.WriteLine("The number is" + randomNumber);
            }
            else if (userEntry > randomNumber)
            {
                Console.WriteLine("Too High!");
                Console.WriteLine("The number is" + randomNumber);
            }
            else
            {
                Console.WriteLine("Correct!");
            }




        }
    }
}
