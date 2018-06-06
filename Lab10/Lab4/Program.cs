using System;
using System.Collections.Generic;
using System.IO;
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
            FileStream file1 = new FileStream("D:\\ПТПО\\Lab10\\text.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            for (int i = 0; i < result.Length; i++)
            {
                writer.Write(result[i] + " "); //записываем в файл
            }
            writer.Close(); //закрываем поток
        }
    }
}
