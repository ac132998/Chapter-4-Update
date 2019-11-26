using System;

namespace Admissions
{
    class Program
    {
        static void Main(string[] args)
        {
            double userEntryGpa;
            int userEntryTestScore;

            Console.WriteLine("Enter GPA:");
            userEntryGpa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter test score:" );
            userEntryTestScore = Convert.ToInt32(Console.ReadLine());

            if (userEntryGpa > 3 && userEntryTestScore > 60)
            {
                Console.WriteLine("Accepted into school!");
            }
            else if (userEntryGpa < 3 && userEntryTestScore > 80)
            {
                Console.WriteLine("Accepted into school!");
            }
            else
            {
                Console.WriteLine("You are rejected hahahahaha!");
            }





        }
    }
}
