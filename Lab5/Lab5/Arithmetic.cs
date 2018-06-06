using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Arithmetic
    {
        public int arithmetic(int[] array)
        {
            int index = 0;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    counter = counter + array[i];
                    index++;
                }
            }
            int result = counter / index;
            return result;
        }

        public int[] InsertInArray(int[] array)
        {
            Arithmetic a = new Arithmetic();
            int average = a.arithmetic(array);
            Calculator calculator = new Calculator();
            int[] result = calculator.NewArray(array);         
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (Math.Abs(array[i]) <= average)
                {
                    result[k] = array[i];
                }
                if (Math.Abs(array[i]) > average)
                {
                    result[k] = array[i];
                    result[k + 1] = 0;
                    k++;
                }
                k++;
            }
            return result;
        }
    }
}
