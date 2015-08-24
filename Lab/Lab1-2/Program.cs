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
            // input
            int[] inputnumber = input();

            //process
            process(inputnumber);

            // output
            output (inputnumber);
        }
        public static int[] input()
        {
            Console.WriteLine("Please Enter How Many Number Do You Want ? ");
            int maximum = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[maximum];
            for (int i=0; i != maximum ; i++)
            {
                Console.Write("Enter Number "+(i+1)+ " : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        // process
        public static void process (int[] inputnumber)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != inputnumber.Length - 1; i++)
                {
                    if (inputnumber[i] > inputnumber[i + 1])
                    {
                        int temp = inputnumber[i];
                        inputnumber[i] = inputnumber[i + 1];
                        inputnumber[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
         
        public static void output(int[] inputnumber)
        {
            for (int i = 0; i != inputnumber.Length; i++)
            {
                Console.Write(inputnumber[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }

}