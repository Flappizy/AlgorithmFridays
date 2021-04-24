using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFridays
{
    class NumberStartAndEnd
    {
        public static string GetNumberStartAndEnd(int[] numbers, int number)
        {
            if (numbers.Length == 0)
            {
                return "[-1, -1]";
            }

            //If array has a length of 1, it is already sorted so skip
            if (numbers.Length != 1)
            {
                Array.Sort(numbers);
            }

            int? start = null;
            int? end = null;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    start = i;
                    break;
                }
            }

            if (start == null)
            {
                return "[-1, -1]";
            }

            for (int i = numbers.Length - 1; i >= start; i--)
            {
                if (numbers[i] == number)
                {
                    end = i;
                    break;
                }
            }

            return $"[{start}, {end}]"; 
        }
    }
}
