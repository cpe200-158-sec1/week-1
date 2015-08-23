using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        //public static int[] input { get; private set; }
        //public static string rawinput { get; private set; }
        static int[] input =new int[1000];
        static int inc;
        static void inputfn()
        {
 
            string rawinput;
            int tmp;
            rawinput = Console.ReadLine();
            int.TryParse(rawinput, out inc);
            for (int i=0;i<inc;i++)
            {
                string rinput = Console.ReadLine();
                int.TryParse(rinput, out tmp);
                input.SetValue(tmp, i);
            }
        }

        // process
        static void process()
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != inc - 1; i++)
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
            for (int i = 0; i != inc; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Input : ");
            inputfn();
            process();
            output();
        }
    }
}
