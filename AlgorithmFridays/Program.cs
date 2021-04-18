using System;

namespace AlgorithmFridays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 0, 1, 0, 0, 1, 1, 0, 0, 1};
            Console.WriteLine(NumberRemoval.RemoveAllNumberOccurrence(numbers, 1));

        }
    }
}
