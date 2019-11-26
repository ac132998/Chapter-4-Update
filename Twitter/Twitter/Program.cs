using System;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string tweet;
            string result = null;
            Console.WriteLine("Enter your tweet >>>");
            tweet = Console.ReadLine();
           
            if (tweet.Length >= 140)
            {
                result = "Tweet is too long. " + tweet.Length;
            }
            else
            {
                result = "Approved " + tweet.Length;
            }

            Console.WriteLine(result);



        }
    }
}
