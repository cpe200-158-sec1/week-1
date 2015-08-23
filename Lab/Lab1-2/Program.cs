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
            int[] input = number();
        
            print(sorting( input));


        }
        static int[] number()
        
        { Console.WriteLine("size?:");
            int size = int.Parse(Console.ReadLine());
            int[] input = new int[size];
            for(int i=0;i<=size-1;i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
             return input;
        }

        static int[] sorting(int[] input)
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

        static void print(int[] input)
        {
            
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

    }
        



}
