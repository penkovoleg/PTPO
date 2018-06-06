using System;

namespace Lab3
{
    public class Calculator
    {

        public int SearchInArray1(int[] array)
        {
            int result = 1;
            int counter = 0;
            int index = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > counter)
                    {
                        counter = array[i];
                        index = i;
                    }
                }
                result = result * counter;
                counter = 0;
                array[index] = 0;
            }
            return result;
        }

        public int SearchInArray2(int[] array)
        {
            int result = 1;
            int counter = 0;
            int index = 0;
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < counter)
                    {
                        counter = array[i];
                        index = i;
                    }
                }
                result = result * counter;
                counter = 0;
                array[index] = 0;
            }
            result = result * max;
            return result;
        }
    }
}

