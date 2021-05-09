using System;
using System.Collections.Generic;

namespace AlgorithmFridays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> {2, 4, 5, 10};
            List<int> list2 = new List<int>() {900, 1};

            List<int> newList = TwoClasses.MergeClasses(list1, list2);
            foreach (int item in newList)
            {
                Console.Write(item + " ");
            }
        }

        static void PrintNumber(int number)
        {
            if (number < 1)
            {
                return;
            }
            else
            {
                PrintNumber(number - 1);
                Console.Write(number + " ");
            }
            return;
        }
    }
}
