using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 2, 4, 1, 6, 8, 5, 3, 7 };
            int[] sortedArray = QuickSort.Sort(numbersArray);
            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
