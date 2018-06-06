using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Calculator
    {
        public int[] NewArray(int[] array)
        {
            Arithmetic a = new Arithmetic();
            int average = a.arithmetic(array);
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > average)
                {
                    index++;
                }
            }
            int[] result = new int[array.Length + index];
            return result;
        }
    }
}
