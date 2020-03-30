using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciLibrary
{
    public static class FibonacciMethods
    {
        public const int MaxNumberOfElements = 93;

        public static long[] GenerateSequence(int elements)
        {
            if (elements < 1)
            {
                return new long[] { };
            }
            else
            {
                if (elements > MaxNumberOfElements)
                {
                    // Option 1:
                    // throw exception
                    // throw new ArgumentOutOfRangeException(nameof(elements), $"Max value is {MaxNumberOfElements}");

                    // Option 2:
                    // force max number of elements
                    elements = MaxNumberOfElements;
                }

                long[] result = new long[elements];

                for (int i = 0; i < elements; i++)
                {
                    if (i < 2)
                    {
                        result[i] = i;
                    }
                    else
                    {
                        result[i] = result[i - 2] + result[i - 1];
                    }
                }

                return result;
            }
        }
    }
}
