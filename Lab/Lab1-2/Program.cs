using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {

        //input
        static public int[] input_value()
        {
            int[] defalut;
            defalut = new int[10];
            for(int i=0;i<defalut.Length;i++)
            {
                defalut[i] = int.Parse(Console.ReadLine());

            }

            return defalut;
           
        }


        //process
        static int[] process(int[] x)
        {
            int[] input = x;
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

        //output
        static void output(int[] ans)
        {
            for (int i = 0; i != ans.Length; i++)
            {
                Console.Write(ans[i]);
                Console.Write(" ");
            }
        }



        static void Main(string[] args)
        {


            // input
            int[] input = input_value(); 
            

            // process
            int[] ans = process(input);

            //output
            output(ans);

            Console.ReadKey();
        }
        
    }
}
