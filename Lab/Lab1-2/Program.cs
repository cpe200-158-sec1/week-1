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
            output1(process1(input1()));
            Console.ReadKey();
        }

        static int[] input1()
        {
            string tmp = Console.ReadLine();
            int[] input = tmp.Split(' ').Select(integer => Convert.ToInt32(integer)).ToArray();
            return input;
        }

        static int[] process1(int[] input)
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
            return input;
        }

        static void output1(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }
    }
}
