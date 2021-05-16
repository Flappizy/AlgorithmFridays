using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFridays
{
    class TwoClasses
    {
        public static List<int> MergeClasses(List<int> classA, List<int> classB)
        {
            List<int> mergedClass = new List<int>(classA.Count + classB.Count);
            
            //Checks if both classes are empty, throws an exception if true
            if (classA == null && classB == null || classA.Count == 0 && classB.Count == 0)
            {
                throw new ArgumentNullException("Both classes are empty");
            }

            //Checks if one of the classes is empty, no need to sort, so i just return the non empty class, since it is already sorted
            if ((classA == null || classB == null) || (classA.Count == 0 || classB.Count == 0))
            {
                mergedClass = classA != null && classA.Count != 0 ? classA : classB;
                return mergedClass;
            }
            

            int indexOfClassA = 0;
            int indexOfClassB = 0;

            //This loop runs as long as the index of classA is less than classA size and index of classB is less than classB size  
            while (indexOfClassA < classA.Count && indexOfClassB < classB.Count)
            {
              
                //Checks if there is an invalid age within any of the classes
                if (classA[indexOfClassA] < 0 || classB[indexOfClassB] < 0)
                {
                    throw new ArgumentOutOfRangeException("Age of student can not be negative");
                }

                //Compares element at specified index of both classes and picks the smallest and add it to our merged class
                if (classA[indexOfClassA] <= classB[indexOfClassB])
                {
                    mergedClass.Add(classA[indexOfClassA++]);
                }
                else
                {
                    mergedClass.Add(classB[indexOfClassB++]);
                }
            }

            //I try to check which of the classes still has element(s) that has not been added to the merged class, if there is/are any, 
            //then i add to the end of merged class
            if (indexOfClassA < classA.Count)
            {
                for (int i = indexOfClassA; i < classA.Count; i++)
                {
                    //Checks if there is an invalid age within the class
                    if (classA[i] < 0)
                    {
                        throw new ArgumentOutOfRangeException("Age of student can not be negative");
                    }
                    mergedClass.Add(classA[i]);
                }
            }
            else
            {
                for (int i = indexOfClassB; i < classB.Count; i++)
                {
                    //Checks if there is an invalid age within the class
                    if (classB[i] < 0)
                    {
                        throw new ArgumentOutOfRangeException("Age of student can not be negative");
                    }
                    mergedClass.Add(classB[i]);
                }
            }

            return mergedClass;
        }
    }
}
