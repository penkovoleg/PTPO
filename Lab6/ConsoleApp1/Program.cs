using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>{ 4, 3, 4, 5, -1, -2, -3, 2};
            Console.Write("Исходные элементы: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(" " + array[i]);
            }
            DeleteInArray delete = new DeleteInArray();
            delete.deletearray(array);
            Console.WriteLine();
            Console.Write("Элементы после удаления: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.ReadLine();
        }
    }
}
