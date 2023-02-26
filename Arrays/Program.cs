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
           // int[] array = arrays.SortArrToMaxSelect(new int[] { 3,4,1,2 });
            int[] array = arrays.SortArrToMinInsert(new int[] { 3,5,1,6,8,2 });
            arrays.PrintArr(array);

            Console.ReadLine();
        }
    }
}
