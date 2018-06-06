using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class DeleteInArray
    {
        public List<int> deletearray(List<int> array)
        {
            int end = array[array.Count - 1];
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % end != 0)
                {
                    array.RemoveAt(i);
                    i--;
                }
            }
            return array;
        }
    }
}
