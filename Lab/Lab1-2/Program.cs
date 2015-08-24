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
            int[] input = inp();
            outp(proc(input));
            Console.ReadKey();

        }

        static int[] inp()
        {
            -int[] x = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            +string recieve = Console.ReadLine();
            +int[] x = recieve.Split(' ').Select(integer => Convert.ToInt32(integer)).ToArray();
            return x;
        }

        static int[] proc(int[] x)
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
            return x;
        }
        static void outp(int[] x)
        {
            for (int i = 0; i != x.Length; i++)
            {
                Console.Write(x[i]);
                Console.Write(" ");
            }
        }
    }
}