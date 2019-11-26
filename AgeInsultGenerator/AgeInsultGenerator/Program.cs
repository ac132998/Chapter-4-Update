using System;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            string result = null;
            Console.WriteLine("Please enter a age so that I may make fun of you!");
            Console.WriteLine("If you call me a bommer you might die of old age.");
            enterAge = Convert.ToInt32(Console.ReadLine());

            if (enterAge <= 12)
            {
                result = "You are just a young punk.";
            }
            else if (enterAge > 12 && enterAge <= 17)
            {
                result = "Your generation is the problem!";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = "Get a job and pay some taxes hippie!";
            }
            else if (enterAge > 25 && enterAge <= 35)
            {
                result = "Gonna move out of your parents any time soon?";
            }
            else if (enterAge > 35 && enterAge <= 45)
            {
                result = "Keep the tupperware Karen";
            }
            else if (enterAge > 45 && enterAge <= 54)
            {
                result = "Go drink some tea or something";
            }
            else if (enterAge > 54 && enterAge <= 62)
            {
                result = "A bit old now you think?";
            }
            else if (enterAge > 62)
            {
                result = "Hi boomer"; 
            }
                    
            Console.WriteLine(result);
        }
    }
}
