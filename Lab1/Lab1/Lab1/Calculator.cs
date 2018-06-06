using System;

namespace lab1
{
    public class Calculator
    {
        public int CalculatorFromYearToCentur(string str)
        {
            int year = Convert.ToInt32(str);
            int size = str.Length;
            int century = 0;
            if (size == 1)
            {
                century = year + 1;
            }
            if (size == 2)
            {
                century = year / 10 + 1;
            }
            if (size == 3 || size == 4)
            {
                century = year / 100 + 1;
            }
            return century;
        }
    }
}
