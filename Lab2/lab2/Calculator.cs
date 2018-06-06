using System;

namespace lab2
{
    public class Calculator {
        public int WorkWithStrings(string str) {
            int result = 0;
            int counter = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str.Length % 2 != 0) {
                    result = -1;
                    counter = 1;
                    break;
                }
                if (str[i] == '(')  {
                    counter++;
                }
                else if(str[i] == ')') {
                    counter--;
                }
            }
            if (counter == 0) {
                result = 0;
            }
            else result = -1;
            return result;
        }
    }
}
