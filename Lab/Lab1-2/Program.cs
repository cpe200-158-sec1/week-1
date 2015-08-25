using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction {

        static int[] input;


        static void Main(string[] args)
        {

            Input();
            Process();
            Output();


           
             
            
        }

        private static void Output()
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

        private static void Process()
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

        private static void Input()
        {
            
            Console.WriteLine("How many number");
            int a =int.Parse(Console.ReadLine());
            input = new int[a];
            for(int i = 0; i < a; i++) { 
            input[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
