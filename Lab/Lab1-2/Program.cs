using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] inputFunc()
        {
            Console.WriteLine("Input your data [10]: ");
            int[] tmp = new int[10];
            for (int i = 0; i != 10; i++)
            {
                Console.Write(i+1);
                Console.Write(": ");
                tmp[i] = int.Parse(Console.ReadLine());
            }
            //int[] input = { tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8], tmp[9] };
            return tmp;
        }
        static void processFunc(int[] input)
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
        }
        static void outputFunc(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }
        static void Main(string[] args)
        {
            int[] data = inputFunc();
            processFunc(data);
            outputFunc(data);
            Console.ReadKey();
        }
    }
}