using System;
using System.Collections.Generic;

namespace AlgorithmFridays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 4, 1, 3 };
            int[] numbers = { 8, 5, 3, 7};
            LinkedList<int> assemblyLine = new LinkedList<int>(numbers);
            LinkedList<int> newassse =  ShuffleClass.ShuffleAssemblyLine(assemblyLine, 2);
            foreach (var item in newassse)
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
