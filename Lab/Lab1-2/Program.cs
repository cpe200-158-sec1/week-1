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
            input();


            Console.ReadKey();
        }
        static void input()
        {            // input
            //int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            int x;
            Console.WriteLine("input length =");
            x = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[x];
            for (int i = 0; i < input.Length; i++)
            {

                Console.WriteLine("enter iput");
                input[i] = Convert.ToInt32(Console.ReadLine());



            }
            process(input);

        }
        static void process(int[] input)
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
            output(input);
        }
        static void output(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }
    }
}
