using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] Input()
        {
            int size;
            Console.Write("Size : ");
            size = int.Parse(Console.ReadLine());
            
            int[] input = new int[size];

            for (int i = 0; i != input.Length ; i++)
            {
                Console.Write(i+1);
                Console.Write(" Input : ");
                input[i] = int.Parse(Console.ReadLine());
            }
            return input;
        }

        static void Process(int[] input)
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

        static void Output(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }

        static void Main(string[] args)
        {
            
            int[] input = { };
            // input
            input = Input();

            // process
            Process(input);

            // output
            Output(input);

            Console.ReadKey();
        }
    }
}
