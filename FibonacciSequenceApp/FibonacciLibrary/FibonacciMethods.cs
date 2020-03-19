using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciLibrary
{
    public static class FibonacciMethods
    {
        public static int[] GenerateSequence(int elements)
        {
            if (elements < 1)
            {
                return new int[] { };
            }
            else
            {
                int[] result = new int[elements];

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
