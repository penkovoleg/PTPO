using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Data
    {
        public int[] Index_One(int[,] arr, int rows, int columns)
        {
            int[] array = new int[rows - 1];
            for (int i = 0; i < columns; i++)
            {
                if (arr[rows - 1, i] < 0)
                {
                    array[0] = i;
                    break;
                }
            }
            return array;
        }

        public int[] Index_Two(int[,] arr, int rows, int columns)
        {
            int[] array = new int[rows - 1];
            for (int i = 0; i < columns; i++)
            {
                if (arr[0, i] > 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        array[0] = i;
                    }
                }
            }
            return array;
        }
    }
}
