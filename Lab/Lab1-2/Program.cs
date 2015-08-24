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
            int[] num = inputfunction();
            processfunction(num);
            outputfunction(num);
            Console.ReadKey();

        }
        static int[] inputfunction()
        {
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return input;
        }
        static void processfunction(int[] x)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != x.Length - 1; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        static void outputfunction(int[] x)
        {
            for (int i = 0; i != x.Length; i++)
            {
                Console.Write(x[i]);
                Console.Write(" ");
            }
        }
    }
}
