using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFridays
{
    class NumberRemoval
    {
        public static int RemoveAllNumberOccurrence(int[] array, int numberToRemove)
        {
           if (array.Length == 0)
            {
                return 0;
            }
            List<int> newNum = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                  if (numberToRemove == array[i])
                  {
                    continue;
                  }
                  newNum.Add(array[i]);
            }
            //This might be an expensive operation if the set of numbers is really Large, but here i am working with a small set of numbers, so
            //it is not a problem
            array = newNum.ToArray();
            return array.Length;
        }

        public static int RemoveAllNumberOccurrenceV2(int[] array, int numberToRemove)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            int length = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (numberToRemove == array[i])
                {
                    continue;
                }
                length++;
            }
            return length;
        }
    }
}
