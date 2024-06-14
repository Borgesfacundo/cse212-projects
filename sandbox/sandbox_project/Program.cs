using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        /*bool divisor = true;
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
        while (divisor){
            Console.WriteLine("Choose a number to be divided");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose a number to divide");
            int num2 = int.Parse(Console.ReadLine());

            int result = findDivisors(num1, num2);
            Console.WriteLine(result);
            Console.WriteLine("Wanna play again? Y/N");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "N") {
                divisor = false;
            }
        }*/
        bool playAgain = true;
        while (playAgain == true)
            {
                Console.WriteLine("First CBU");
                string cbu1 = Console.ReadLine();

                Console.WriteLine("Second CBU");
                string cbu2 = Console.ReadLine();

                if (Equals(cbu1, cbu2) == true)
                {
                    Console.WriteLine("Are Equals");
                }
                else
                {
                    Console.WriteLine("Are NOT Equals");
                }

                Console.WriteLine("Wanna try again? Y/N");
                string input = Console.ReadLine().ToLower();
                if (input == "n") {
                    break;
                }
            };

    }
    public static bool Equals(int a, int b)
    {
        bool equal;
        if (a == b)
        {
            equal = true;
            return equal;
        }
        else
        {
            return equal = false;
        }

    }
}

/* static int findDivisors(int number, int divisor)
 {
     int result = number % divisor;
     return result;
 }
}*/