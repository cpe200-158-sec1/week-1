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
            int[] input = new int[10];
            inputt(input);
            process(input);
            output(input);
            Console.ReadKey();

        }


       static void inputt(int[] inputnum)
        {
            for (int i = 0; i != inputnum.Length; i++)
                inputnum[i] = int.Parse(Console.ReadLine());

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
