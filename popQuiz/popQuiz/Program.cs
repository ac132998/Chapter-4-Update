using System;

namespace popQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            double userEntryFarenheit1;
            double userEntryFarenheit2;
            double userEntryFarenheit3;
            double celuis1;
            double celuis2;
            double celuis3;

            Console.WriteLine("Enter temperature in Farenheit at 8:00 AM >>> ");
            userEntryFarenheit1 = Convert.ToDouble(Console.ReadLine());
           
            celuis1 = (userEntryFarenheit1 - 32) / (9 / 5);
            
            if (userEntryFarenheit1 <= 32)
            {
                Console.WriteLine("It is freezing!");
            }
            else if (userEntryFarenheit1 >= 100)
            {
                Console.WriteLine("It is hot outside!");
            }

            Console.WriteLine("At 8:00 AM, it was " + userEntryFarenheit1 + " degrees farenheit " +
               celuis1 + " degrees Celsius");

            Console.WriteLine("Enter temperature in Farenheit at 12:00 PM >>> ");
            userEntryFarenheit2 = Convert.ToDouble(Console.ReadLine());

            celuis2 = (userEntryFarenheit2 - 32) / (9 / 5);

            if (userEntryFarenheit2 <= 32)
            {
                Console.WriteLine("It is freezing!");
            }
            else if (userEntryFarenheit2 >= 100)
            {
                Console.WriteLine("It is hot outside!");
            }

            Console.WriteLine("At 12:00 PM, it was " + userEntryFarenheit2 + " degrees farenheit " +
            celuis2 + " degrees Celsius");

            Console.WriteLine("Enter temperature in Farenheit at 5:00 PM >>> ");
            userEntryFarenheit3 = Convert.ToDouble(Console.ReadLine());

            celuis3 = (userEntryFarenheit3 - 32) / (9 / 5);

            if (userEntryFarenheit3 <= 32)
            {
                Console.WriteLine("It is freezing!");
            }
            else if (userEntryFarenheit3 >= 100)
            {
                Console.WriteLine("It is hot outside!");
            }
         
            Console.WriteLine("At 5:00 PM, it was " + userEntryFarenheit3 + " degrees farenheit " +
                           celuis3 + " degrees Celsius");

        }


    }
}
