using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            return PSort(array, 0, array.Length - 1);
        }
        public static int[] PSort(int[] array, int start, int end)
        {
            if (start >= end)
                return array;
            // Find the index of the pivot
            int partitionIndex = Partition(ref array, start, end); // Calling partition
            PSort(array, start, partitionIndex - 1);
            PSort(array, partitionIndex + 1, end);
            return array;
        }
        public static int Partition(ref int[] array, int start, int end)
        {
            int pivot = array[end];
            int partitionIndex = start; // Set partition index as start index intially

            for (int i = start; i < end - 1; i++)
            {
                if(array[i] <= pivot)
                {
                    // Swap if element is lesser than the pivot
                    int current = array[i];
                    array[i] = array[partitionIndex];
                    array[partitionIndex] = current;
                    partitionIndex++;
                }
            }

            // Swap the element at pIndex with the one at the end, the end element is actually the pivot
            int currentPivot = array[partitionIndex];
            array[partitionIndex] = array[end];
            array[end] = currentPivot;

            return partitionIndex;
        }
    }
}
