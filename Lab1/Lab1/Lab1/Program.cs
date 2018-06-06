using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год: ");
            string str = Console.ReadLine();
            Calculator calculator = new Calculator();
            int century = calculator.CalculatorFromYearToCentur(str);
            Console.WriteLine("Столетие: " + century);
            Console.ReadLine();
        }
    }
}
