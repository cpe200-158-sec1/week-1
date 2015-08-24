using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        // input funtion
        static int[] input()
        {
            int n = 0;
            Console.Write("Please enter number of values that will be sorted : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your ");
            Console.Write(n );
            Console.WriteLine(" values : ");
            int[] input = new int[n];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            return input;

        }

        // process function
        static void process(int[]input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i!=input.Length -1; i++)
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

        // output function
        static void output(int[] input)
        {
            Console.WriteLine("Your sorted values are : ");
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            int[] n = { };
            n = input();
            process(n);
            output(n);
        }
    }
}
