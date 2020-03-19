using FibonacciLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciConsole
{
    public static class ConsoleHelper
    {
        public static int[] CreateFibonacciSequence(int maxAttempts) 
        {
            int attempt = 1;

            bool isValid = false;

            while (!isValid && attempt <= maxAttempts)
            {
                Console.Write($"Number of elements (Attempt { attempt }): ");
                isValid = int.TryParse(Console.ReadLine(), out int numberOfElements);

                if (isValid)
                {
                    int[] result = FibonacciMethods.GenerateSequence(numberOfElements);
                    return result;
                }
                attempt++;
            }

            return new int[] { };
        }

        public static void PrintSequence(int[] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array.Length is 0)
            {
                Console.WriteLine("Nu exista elemente in sirul lui Fibonacci!", Console.ForegroundColor = ConsoleColor.Red);
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sb.Append(array[i] + ", ");
                }

                sb.Remove(sb.Length - 2, 2);
                Console.WriteLine($"The required Fibonacci's Sequence is: [{ sb }]", Console.ForegroundColor = ConsoleColor.Green);
            }
            
        }
    }
}
