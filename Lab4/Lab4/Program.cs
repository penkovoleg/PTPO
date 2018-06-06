using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            int[] array = data.DataEntry();
            Calculator calculator = new Calculator();
            int[] result = calculator.ReshuffleInArray(array);
            Console.Write("Массив после замены: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(" " + result[i]);
            }
            Console.ReadLine();
        }
    }
}
