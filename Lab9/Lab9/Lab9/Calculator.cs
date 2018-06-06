using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Calculator
    {
        public int[,] SortInArray(int[,] array, int rows, int columns)
        {
            int element = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int x = 0; x < rows; x++)
                    {
                        for (int y = 0; y < columns; y++)
                        {
                            if (array[i, j] > array[x, y])
                            {
                                element = array[i, j];
                                array[i, j] = array[x, y];
                                array[x, y] = element;
                            }
                        }
                    }
                }
            }
            return array;
        }
    }
}
