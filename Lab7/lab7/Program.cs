using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4] { { 4, 3, 2, 1 },
                                           { 5, 6, 7, 8 }, 
                                           { 1, -2, -3, 4 }
            };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            Console.WriteLine("Массив до:");
            for (int i = 0; i < rows; i++)//столбцы
            {
                for (int j = 0; j < columns; j++)//строки
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); 
            Calculator calculator = new Calculator();
            array = calculator.reshuffle(array, rows, columns);
            Console.WriteLine("Массив после:");
            for (int i = 0; i < rows; i++)//столбцы
            {
                for (int j = 0; j < columns; j++)//строки
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }           
            Console.ReadLine();
        }
    }
}
