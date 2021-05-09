using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFridays
{
    class ElementProducts
    {
        //This algorithm works in a way that, i try to find the products of a given array from the left edge up to index i example {1, arr[0], arr[0]*arr[1], 
        //arr[1]*arr[2]*arr[3]  }
        //Then i try to find the products of the given array from the right edge up to index i example {arr[1]*arr[2]*arr[3], arr[2]*arr[3], arr[3], 1}
        //Then i take the two resulting edges left and right and multiply their element at corresponding position against each other example "products[] =  
        //left[0] * right[0]" and it goes on like that until i reach the final index
        public static int[] FindElementProduct(int[] array)
        {
            if (array?.Length == null)
            {
                throw new InvalidOperationException("Array is empty");
            }

            
            int[] products = new int[array.Length];
            int product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                products[i] = product;
                product *= array[i];
            }

            product = 1;

            //The trick here is that i was trying to avoid a space complexity of O(N) so instead of creating two new arrays for the products of the right
            //edge to index i and the final resulting products
            //i used the product variable to temporarily hold the product of each index from the right edge and immediately 
            //multiplied it against what i already have in the products variale(left edge results). Hope it makes sense
            for (int i = array.Length -1; i >= 0; i--)
            {
                products[i] *= product;
                product *= array[i]; 
            }

            return products;
        }

        static void Main1(string[] args)
        {
            int[] array = { 4, 5, 10, 2 };
            int[] products = ElementProducts.FindElementProduct(array);
            foreach (var item in products)
            {
                Console.Write(item + " ");
            }
        }
    }
}
