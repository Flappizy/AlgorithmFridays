using System;

namespace AlgorithmFridays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 2, 0, 3 };
            int[] products = ElementProducts.FindElementProduct(array);
            foreach (var item in products)
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
