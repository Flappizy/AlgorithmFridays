using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFridays
{
    class ShuffleClass
    {
        public static LinkedList<int> ShuffleAssemblyLine(LinkedList<int> assemblyLine, int shuffleNumber)
        {
            //Checks if the Assembly line is empty, if it is throw an exception
            if (assemblyLine.Count == 0 || assemblyLine == null)
            {
                throw new ArgumentNullException("Can not shuffle empty class");
            }

            //Checks if the Assembly line has a single student on the line, if true returns the assembly line, because there is no point shuffling
            //Or check if the number of times we need to shuffle  is equal to 0, then we do not need to shuffle, just return the
            //assembly line as it is
            if (assemblyLine.Count == 1 || shuffleNumber.Equals(0))
            {
                return assemblyLine;
            }

            //Checks if the number of times we need to shuffle is equal to the size of the Assembly line, if true, then there is 
            //no point shuffling because we are always going to end up having the same assembly line as the original one
            if (assemblyLine.Count == Math.Abs(shuffleNumber))
            {
                return assemblyLine;
            }

            LinkedList<int> newAssemblyLine = assemblyLine;
            int count = 0;
              
            //Checks if the shuffle number is positive then we move students from the end of the line to the front
            if (shuffleNumber > 0)
            {                
                while (count < shuffleNumber)
                {
                    int lastElement = newAssemblyLine.Last.Value;
                    newAssemblyLine.AddFirst(lastElement);
                    newAssemblyLine.RemoveLast();
                    count++;
                }
                return newAssemblyLine;
            }
            //If the shuffle number is negative, we move students from the front of the line to the end
            else
            {
                while (count < Math.Abs(shuffleNumber))
                {
                    int firstElement = newAssemblyLine.First.Value;
                    newAssemblyLine.AddLast(firstElement);
                    newAssemblyLine.RemoveFirst();
                    count++;
                }
                return newAssemblyLine;
            }
        }


        static void Main(string[] args)
        {
            //int[] numbers = { 4, 1, 3 };
            int[] numbers = { 8, 5, 3, 7 };
            LinkedList<int> assemblyLine = new LinkedList<int>(numbers);
            LinkedList<int> newassse = ShuffleClass.ShuffleAssemblyLine(assemblyLine, 2);
            foreach (var item in newassse)
            {
                Console.Write(item + " ");
            }
        }
    }
}
