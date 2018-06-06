using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
    public class Calculator {
        public int[] ReshuffleInArray(int[] array) {
            int negative = 0;
            int positive = 0;
            int counter = 0;
            int max = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > max) {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++) {
                if (array[i] < negative) {
                    negative = array[i];
                    counter = i;
                }
                if (array[i] > 0 && array[i] < max) {
                    max = array[i];
                    positive = array[i];
                    index = i;
                }
            }
            array[counter] = positive;
            array[index] = negative;
            return array;
        }
    }
}
