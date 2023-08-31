using System;
using System.Linq;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        //mr.mps
        public static void ThousandsCt()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountBy3()
        {
            for (int j = 3; j <= 999; j += 3)
            {
                Console.WriteLine(j);
            }
        }



        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void AreTheyEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int b)
        {
            if (b > 0)
            {
                Console.WriteLine("positive");
            }

            if (b < 0)
            {
                Console.WriteLine("negative");
            }
            if (b == 0)
            {
                Console.WriteLine("neither");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //With age and voting, you can say “You may vote” or “Looks like you're too young this time!” based on their age.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanYouVote()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You may vote!");
            }
            else
            {
                Console.WriteLine("Try again next election!");
            }
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void NumberRange()
        {
            Console.WriteLine("Type a number please?");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine("Good guess!");
            }
            else
            {
                Console.WriteLine("Try again :(");
            }
        }

        //GitHub answer:
        //public static bool IsTenRange(int num)
        //{
        //    if (num <= 10 && num >= -10)
        //    {
        //        return true;
        //    }

        //    return false;



        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        //COULD NOT GET TO WORK BUT MIGHT BE CLOSE!:

        //public static void MultiplyTable()
        //{
        //    Console.WriteLine("Type a number between 1 and 12 to see its corresponding times table");
        //    int userNumb = int.Parse(Console.ReadLine());

        //    if (userNumb <= 12 && userNumb >= 1)
        //    {
        //        for (int k = 0; k < 11; k++)
        //        {
        //            Console.WriteLine(usernumb*k);
        //        }
        //    }
        //    else 
        //    { 
        //        Console.WriteLine("Not a valid number. Choose again."); 
        //    }
        //}


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
                {
            ThousandsCt();
            CountBy3();
            AreTheyEqual(10, 9);
            EvenOrOdd(3);
            PosOrNeg(0);
            CanYouVote();
            NumberRange();
            //MultiplyTable();
        }
        }
    } 
