using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скобки: ");
            string str = Console.ReadLine();
            Calculator calculator = new Calculator();
            int result = calculator.WorkWithStrings(str);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
