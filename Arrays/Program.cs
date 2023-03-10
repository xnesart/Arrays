using Arrays.Classes;
using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraysClass arrays = new ArraysClass();
            DoubleArraysClass doubleArr = new DoubleArraysClass();
            //int min = arrays.FindMinValue(new int[] { 1, 23, 4, 56, 7 });

            //int sumOfIndex = arrays.SumOfElementsWithOddIndexArray(new int[] { 1, 23, 4, 56, 7 });
            //int[] arr = arrays.ArrayReverse(new int[] { 1, 23, 4, 56, 7 });
            //int sum = arrays.SumOfOddElements(new int[] { 1, 23, 4, 56, 7 });
            int[] array = arrays.SortArrToMaxSelect(new int[] { 3, 5, 1, 6, 8, 2, 99,23,55 });
            //int[] array = arrays.SortArrToMinInsert(new int[] { 3, 5, 1, 6, 8, 2, 34,54,23,123,76 });
            arrays.PrintArr(array);
            //string index = doubleArr.FindMaxIndexInDoubleArray(new int[,]{ { 1, 2, 3 },
            //    { 4,-4,-1} }
            //);
            //string indexx = doubleArr.FindMinIndexInDoubleArray(new int[,]{ { 1, 2, 3 },
            //    { 4,-4,-1} });
            //int count = doubleArr.FindCountOfElementsLargerThanTheirLeftAndBottomNeighbors(new int[,]{ { 1, 2, 3 },
            //    { 4,-4,-1} });
            //Console.WriteLine(count);
            //doubleArr.PrintDoubleArray(minn);

            Console.ReadLine();
        }
    }
}
