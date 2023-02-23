using Arrays.Classes;
using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraysClass arrays = new ArraysClass();
            int min = arrays.FindMinValue(new int[] { 1, 23, 4, 56, 7 });

            int sumOfIndex = arrays.SumOfElementsWithOddIndexArray(new int[] { 1, 23, 4, 56, 7 });
            int[] arr = arrays.ArrayReverse(new int[] { 1, 23, 4, 56, 7 });
            int sum = arrays.SumOfOddElements(new int[] { 1, 23, 4, 56, 7 });
            int[] array = arrays.SwapPartsOfArray(new int[] { 1, 2, 3, 4, 5 });
            arrays.PrintArr(array);

            Console.ReadLine();
        }
    }
}
