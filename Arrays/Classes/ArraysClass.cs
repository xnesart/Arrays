using System;

namespace Arrays.Classes
{
    public class ArraysClass
    {
        public int FindMinValue(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public int FindMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public int FindMaxIndexOValue(int[] array)
        {
            int maxIndex = 0;
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public int FindMinIndexOValue(int[] array)
        {
            int minIndex = 0;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public int SumOfElementsWithOddIndexArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        public int[] ArrayReverse(int[] array)
        {
            int[] newArray = new int[array.Length];
            int tmp = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[tmp] = array[i];
                tmp++;
            }
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = newArray[j];
            }

            return array;
        }

        public int SumOfOddElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum++;
                }
            }

            return sum;
        }

        public int[] SwapPartsOfArray(int[] array)
        {
            int tmp = 0;
            int[] newArray = new int[array.Length];
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                newArray[tmp] = array[i];
                tmp++;
            }
            for (int j = 0; j < array.Length / 2; j++)
            {
                newArray[tmp] = array[j];
                tmp++;
            }
            array = newArray;

            return array;

        }

        public void PrintArr(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
