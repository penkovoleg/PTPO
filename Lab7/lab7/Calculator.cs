using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Calculator
    {
        public int[,] reshuffle(int[,] array, int rows, int columns)
        {
            Data data = new Data();
            int[] index_one = data.Index_One(array, rows, columns);
            int[] index_two = data.Index_Two(array, rows, columns);
            int[] arr = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == rows - 1 && j == index_one[0])
                    {
                        for (int x = 0; x < arr.Length; x++)
                        {
                            arr[x] = array[rows - 1 - x, index_one[0]];
                            array[rows - 1 - x, index_one[0]] = array[rows - 1 - x, index_two[0]];
                            array[rows - 1 - x, index_two[0]] = arr[x];
                        }
                    }
                }
            }
            return array;
        }
    }
}
