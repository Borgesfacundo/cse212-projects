using System;

public class Program
{
    static void Main(string[] args)
    {
        bool divisor = true;
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
        }
    }

    static int findDivisors(int number, int divisor)
    {
        int result = number % divisor;
        return result;
    }
}