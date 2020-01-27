using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            int length = array.Length;

            // Base condition
            if (length < 2)
                return array;

            int midPoint = length / 2;

            // Create the two arrays
            int[] left = new int[midPoint];
            int[] right = new int[length - midPoint];

            // Fill up the two arrays starting with left one
            for (int i = 0; i < midPoint; i++)
            {
                left[i] = array[i];
            }

            for (int i = midPoint; i < length; i++)
            {
                right[i - midPoint] = array[i];
            }

            // Make a recursive call to sort both left and right
            left = Sort(left);
            right = Sort(right);
            array = Merge(left, right, array);
            return array;
        }

        private static int[] Merge(int[] left, int[] right, int[] array)
        {
            // Find the length of the arrays
            int nL = left.Length;
            int nR = right.Length;
            int nA = array.Length;

            int i, j, k;
            i = j = k = 0;

            while (i < nL && j < nR)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++; 
            }

            // Fill up the remaining values from one of the two arrays
            while (i < nL)
            {
                array[k] = left[i];
                i++;
                k++;
            }

            while (i < nR)
            {
                array[k] = left[j];
                j++;
                k++;
            }
            return array;
        }
    }
}
