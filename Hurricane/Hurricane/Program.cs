using System;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            double windSpeed;
            Console.WriteLine("Enter wind speed >>> ");
            windSpeed = Convert.ToDouble(Console.ReadLine()); 

            if (windSpeed >= 157)
            {
                Console.WriteLine("Catorgory 5 Hurricane");
            }
            else if (windSpeed >= 130)
            {
                Console.WriteLine("Catorgory 4 Hurricane");
            }
            else if (windSpeed >= 111)
            {
                Console.WriteLine("Catorgory 3 Hurricane");
            }                
            else if (windSpeed >= 96)
            {
                Console.WriteLine("Catorgory 2 Hurricane");
            }
            else if (windSpeed >= 74)
            {
                Console.WriteLine("Catorgory 1 Hurricane");
            }
            else
            {
                Console.WriteLine("Not a hurricane");
            }


        }
    }
}
