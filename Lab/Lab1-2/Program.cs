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
           

       
            int[]  input = intputsort();
            
            input = processsort(input);

            outputsort(input);

        }

        static int[] intputsort()
        {
            
                //{ 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
           
            // input
            Console.Write("Enter number of array size : ");
            int size = int.Parse(Console.ReadLine());
            int[] input = new int[size];
            for (int i=0; i<size;i++)
            {
                Console.Write("Enter the Number( "+(i+1)+" ) : ");
                input[i] = int.Parse(Console.ReadLine());

            }


            return input;
        }

        static int[] processsort(int[] input)
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

            return input;
        }

        static void outputsort(int[] input)
        {

            // output

            Console.Write("Answer is : ");

            for (int i = 0; i != input.Length; i++)
            {
               
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();

        }
    }
}
