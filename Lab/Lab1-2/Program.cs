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
            int[] inp = Input();
            Output(Process(inp));
            Console.ReadKey();         
        }
        static int[] Input()
           {
            string recieve = Console.ReadLine();
            int[] input = recieve.Split(' ').Select(integer => Convert.ToInt32(integer)).ToArray();
            return input;
           }

        static int[] Process(int[] input)
        {
            // process
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
        static void Output(int[] input)
        {
            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
