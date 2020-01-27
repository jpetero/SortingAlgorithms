using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            for (int k = 0; k < array.Length - 1; k++)
            {
                int flag = 0; 
                // Stop at n - 2 index since n - 1 would not have the next index
                // Stop at n - k - 1 since the other remaining part would be sorted already
                for (int i = 0; i < array.Length - k - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap the array at i with i + 1
                        int current = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = current;
                        //flag = 1;
                    }
                }

                // To avoid making redundant passes
                //if (flag == 0)
                //    break;
            }
            return array;
        }
    }
}
