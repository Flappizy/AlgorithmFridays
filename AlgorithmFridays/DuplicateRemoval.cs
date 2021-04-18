using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFridays
{
    class DuplicateRemoval
    {
        public static int RemoveDuplicate(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            
            List<int> newArr = new List<int>();
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (newArr.Count == 0)
                {
                    newArr.Add(numbers[i]);
                    continue;
                }
                else if (newArr[index] != numbers[i] )
                {
                    newArr.Add(numbers[i]);
                    index++;
                    continue;
                }
            }
            //This might be an expensive operation if the set of numbers is really Large, but here i am working with a small set of numbers, so
            //it is not a problem
            numbers = newArr.ToArray();
            return numbers.Length;
        }
    }
}
