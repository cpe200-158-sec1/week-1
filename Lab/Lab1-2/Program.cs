using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            // input
            int[] inputnumber = input();

            //process
            process(inputnumber);

            // output
            output (inputnumber);
        }
        public static int[] input()
        {
            int[] ber = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return ber;
        }
        // process
        public static void process (int[] inputnumber)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != inputnumber.Length - 1; i++)
                {
                    if (inputnumber[i] > inputnumber[i + 1])
                    {
                        int temp = inputnumber[i];
                        inputnumber[i] = inputnumber[i + 1];
                        inputnumber[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
         
        public static void output(int[] inputnumber)
        {
            for (int i = 0; i != inputnumber.Length; i++)
            {
                Console.Write(inputnumber[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }

}