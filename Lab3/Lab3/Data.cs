using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Data
    {
        public int[] DataEntry()
        {
            Console.WriteLine("Введите числа: ");
            string str = Console.ReadLine();
            string[] st = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = st.Length;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(st[i]);
            }
            return array;
        }
    }
}
