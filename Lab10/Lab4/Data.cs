using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Data
    {
        public int[] DataEntry()
        {
            FileStream file1 = new FileStream("D:\\ПТПО\\Lab10\\input.txt", FileMode.Open); //создаем файловый поток
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 
            string str = reader.ReadToEnd();
            reader.Close(); //закрываем поток
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
