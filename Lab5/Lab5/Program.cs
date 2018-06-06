using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            int[] array = data.DataEntry();
            Arithmetic a = new Arithmetic();
            array = a.InsertInArray(array);
            Console.Write("Массив после вставки: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.ReadLine();
        }
    }
}
