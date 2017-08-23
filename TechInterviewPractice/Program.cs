using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Tech_Interview_Questions
    {
        class Program
        {
            static void Main(string[] args)
            {

                //PROBLEM: If number is divisible by 3, print "FIZZ." If number is divisible by 5, print "BUZZ." If divisible by both, print "FIZZBUZZ." If it is divisible by neither, say so.
                Console.WriteLine("Please choose an integer.");
                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber % 5 == 0 && userNumber % 3 == 0)
                    //could also see if it's divisible by 15 and that would obtain the same result
                    Console.WriteLine("FIZZBUZZ");

                else if (userNumber % 5 == 0)

                    Console.WriteLine("BUZZ");

                else if (userNumber % 3 == 0)

                    Console.WriteLine("FIZZ");

                else

                    Console.WriteLine("The number is not divisible by 3 or 5.");

                //Prime number practice

                Console.WriteLine("Please enter a number between 1 and 25");

                int numberGuess = int.Parse(Console.ReadLine());

                if (numberGuess < 1 || numberGuess > 25)
                {
                    Console.WriteLine("The number is too big.");
                }

                else if (numberGuess == 2 || numberGuess == 3 || numberGuess == 5 || numberGuess == 7 || numberGuess == 11 || numberGuess == 13 || numberGuess == 17 || numberGuess == 19 || numberGuess == 23)
                {
                    Console.WriteLine("The number is a prime.");
                }
                else
                {
                    Console.WriteLine("The number is not a prime.");
                }

            }
        }
    }

}
    }
}
