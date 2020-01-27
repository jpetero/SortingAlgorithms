using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int value = array[i];
                int hole = i;
                while(hole > 0 && array[hole - 1] > value)
                {
                    array[hole] = array[hole - 1];
                    hole = hole - 1;
                }

                array[hole] = value;
            }

            return array;
        }
    }
}
