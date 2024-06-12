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

        Console.WriteLine("\n======================\nSimple Stack\n======================");

        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        stack.Pop();
        stack.Push(4);
        stack.Push(5);
        stack.Pop();
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);
        stack.Push(9);
        stack.Pop();
        stack.Pop();
        stack.Push(10);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(11);
        stack.Push(12);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(13);
        stack.Push(14);
        stack.Push(15);
        stack.Push(16);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(17);
        stack.Push(18);
        stack.Pop();
        stack.Push(19);
        stack.Push(20);
        stack.Pop();
        stack.Pop();

        Console.WriteLine("Final contents:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));
    }
}

/* static int findDivisors(int number, int divisor)
 {
     int result = number % divisor;
     return result;
 }
}*/