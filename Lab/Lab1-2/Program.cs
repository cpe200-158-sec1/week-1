using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        public static int[] input { get; private set; }

        // input
        static void inputfn()
        {
           input = new int[]{ 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
        }

        // process
        static void process()
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

        // output
        static void output()
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            //int[] input;
            //BubbleSortFunction target = new BubbleSortFunction();
            inputfn();
            process();
            output();
        }
    }
}
