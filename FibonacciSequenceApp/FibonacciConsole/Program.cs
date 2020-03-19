using System;

namespace FibonacciConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacciSequence = ConsoleHelper.CreateFibonacciSequence(3);

            ConsoleHelper.PrintSequence(fibonacciSequence);

            Console.ReadLine();
        }
    }
}
