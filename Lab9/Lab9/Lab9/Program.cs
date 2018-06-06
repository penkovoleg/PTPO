using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] {{8, 4, 2}, 
                                          {6, 3, 5},
                                          {9, 7, 1}
            };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            Console.WriteLine("Массив до сортировки:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив после сртировки: ");
            Calculator calculator = new Calculator();
            int[,] arr = calculator.SortInArray(array, rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
