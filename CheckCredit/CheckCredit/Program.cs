using System;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterPrice;
            string result = null;
            Console.WriteLine("Enter the price of item >>>>");
            enterPrice  = Convert.ToInt32(Console.ReadLine());

            if (enterPrice > 5000)
            {
                result = "Card Denied";
            }
            else
            {
                result = "Approved"; 
            }
            Console.WriteLine(result);

        }
    }
}
