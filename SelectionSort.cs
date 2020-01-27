using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            // The element at n - 1 would be appropriate, no need to reach it
            for (int i = 0; i < array.Length -1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j; // Update the index of the minimum element
                }

                // Swap the minimum with value at ith position
                int current = array[i];
                array[i] = array[minIndex];
                array[minIndex] = current;
            }
            return array;
        }
    }
}
