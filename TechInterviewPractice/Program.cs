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

            //TESTING THE METHODS
            int[] firstArray = { 6, 2, 5 };
            int[] secondArray = { 4, 1, 7 };
            Console.WriteLine(CompareArrays(firstArray, secondArray));

            int userAge = 67;
            Console.WriteLine(CategorizeAge(userAge));

            int number1 = 3;
            int number2 = 5;
            Console.WriteLine(Add(number1, number2));


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


            //REFERENCE TYPES VS VALUE TYPES
            int x = 1;
            int y = x; //the VALUE of "x" is being stored into y. Not "whatever x is"! 
            x = 10;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Customer customer1 = new Customer(25);
            Customer customer2 = customer1; //customer 1 and customer 2 are now pointing to the same object; if you change one, you change both (reference type)

            Console.WriteLine(customer1.age);
            customer2.age = 30;
            Console.WriteLine(customer1.age);
            Console.WriteLine(customer2.age);

            //TECH INTERVIEW QUESTION
            //Print out all prime numbers that are less than 100 to the console.

            Console.WriteLine("Begin Prime Number Example.");
            int n = 100;
            bool isPrime = true;

            for (int i = 2; i <= n; i++)
            {
                for (int m = 2; m < i; m++)
                {
                    if (i != m && i % m == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }

             isPrime = true; //need to reset the loop to repeat

            }

            //TECH INTERVIEW QUESTION
            //Create a method that takes one int Array and returns the largest number in that array.
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine(FindLargest(nums));
            Console.WriteLine(AlsoFindLargest(nums));

            //TECH INTERVIEW QUESTION
            //Create a method that takes a string parameter then returns that string in reverse (do not use .Reverse)
            //Instead of creating an entirely new string or array (for example), you can reverse it IN PLACE (look this up)

            string myMessage = "Hello";
            Console.WriteLine(myMessage);
            Console.WriteLine(ReverseText(myMessage));

            //TECH INTERVIEW QUESTION
            //Return "True" if the string is a palindrome.

        }

        //Creating the method: that takes one int Array and returns the largest number in that array.
        public static int FindLargest(int[] userArray)
        {
            Array.Sort(userArray);
            int largest = userArray[userArray.Length - 1];
            return largest;
        }

        public static int AlsoFindLargest(int[] userArray)
        {
            int largestNumber = userArray[0];
            for (int i = 0; i<userArray.Length; i++)
            {
                if (userArray[i] > largestNumber)
                {
                    largestNumber = userArray[i];
                }
            }
            return largestNumber;   
        }

        //Creating the method: takes a string parameter then returns that string in reverse
        public static string ReverseText(string userText)
        {
            string Reverse = "";
            for (int i = userText.Length-1; i>=0; i--)
            {
                Reverse += userText[i]; //adding parts together piece by piece 
            }
            return Reverse;
        }

        //Create a method that adds two integers together
        public static int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        //Create a method that returns different categories based on someone's age
        public static string CategorizeAge(int userAge)
        {
            if (userAge <= 3)
            {
                return "young child";
            }
            else if (userAge > 3 && userAge <= 20)
            {
                return "child";
            }
            else
            {
                return "adult";
            }
        }

        //Create a method that compares two arrays and if any element in any index location is the same
        //then it is true 
        public static bool CompareArrays(int[] array1, int[] array2)
        {
            bool arrayEquality = false;
            for(int i=0; i<=array1.Length-1; i++)
            {
                for(int m=0;  m<=array2.Length-1; m++)
                {
                    if (array1[i] == array2[m])
                    {
                        arrayEquality = true;
                        break;
                    }
                    else
                    {

                    }
                }
            }
            return arrayEquality;
        }
    }
}


    

