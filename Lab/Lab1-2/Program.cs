﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] input()
        { 
            int[] input = new int[10];
            for (int i = 0;i<input.Length;i++) {
                input[i] = int.Parse(Console.ReadLine());    
            }
            return input;
        }

        static void process(int []input)
        {
            bool flag = true;



            // process
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


        static void output(int[]input)
        {
            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }

        static void Main(string[] args)
        {
            int[] a = { };
            a = input();
            process(a);
            output(a);
            
            Console.ReadKey();
        }
    }
}
