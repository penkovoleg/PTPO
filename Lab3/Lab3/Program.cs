using System;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            int[] array = data.DataEntry();
            Calculator calculator = new Calculator();
            int[] arrayCopy = array.ToArray();
            int max1 = calculator.SearchInArray1(array);
            int max2 = calculator.SearchInArray2(arrayCopy);
            if(max1 > max2) Console.WriteLine("Произведение трех максимальных чисел: " + max1);
            if(max2 > max1) Console.WriteLine("Произведение трех максимальных чисел: " + max2);
            Console.ReadLine();
        }
    }
}
