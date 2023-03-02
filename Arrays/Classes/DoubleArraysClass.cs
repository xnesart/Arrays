using System;

namespace Arrays.Classes
{
    internal class DoubleArraysClass
    {
        public int FindMinInDoubleArray(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        public int FindMaxInDoubleArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        public string FindMaxIndexInDoubleArray(int[,] array)
        {
            int max = array[0, 0];
            string index = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        index = ($"i = {i}, j = {j}");
                    }
                }
            }
            return index;
        }
        public string FindMinIndexInDoubleArray(int[,] array)
        {
            int min = array[0, 0];
            string index = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        index = ($"i = {i}, j = {j}");
                    }
                }
            }
            return index;
        }
        //Найти количество элементов массива, которые больше своих левого и нижнего соседа одновременно.
        public int FindCountOfElementsLargerThanTheirLeftAndBottomNeighbors(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == 0 || arr[i, j] > arr[i - 1, j])
                    && (i >= arr.GetLength(0) - 1 || arr[i, j] > arr[i + 1, j])
                    && (j == 0 || arr[i, j] > arr[i, j - 1])
                    && (j >= arr.GetLength(1) - 1 || arr[i, j] > arr[i, j + 1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public void PrintDoubleArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
    }
}
