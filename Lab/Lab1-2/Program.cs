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
            int[] innum;
            innum = input();
            innum = process(innum);
            output(innum);
        }
        static int[] input()
        {
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return (input);
        }
        static int[] process(int[] input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            return (input);
        }
        static void output(int[] data)
        {
            for (int i = 0; i != data.Length; i++)
            {
                Console.Write(data[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
