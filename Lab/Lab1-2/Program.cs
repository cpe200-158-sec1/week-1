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
            bool flag = true;
        }
        Console.Readkey();
        }

    static void Main(string[] args)
    {
        outp(proc(inp()));
        Console.Readkey();
    }

    // input
    static int[] inp()
    {
        string recieve = Console.ReadLine();
        int[] input = recieve.Split(' ').Select(integer => Convert.ToInt32(integer));
        return input;
    }
    // process
    static int[] proc(int[] input)
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

    // output
    static void outp(int[] input)
    {

        for (int i = 0; i != input.Length; i++)
        {
            Console.Write(input[i]);
            Console.Write(" ");
        }
    }
}
}
   

            
           

     
    

