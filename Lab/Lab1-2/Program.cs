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
            input_Num(input);
            process(input);
            output(input);

            Console.ReadKey();
        }


        static void input_Num(int[] _input)
        {
            for (int i=0; i != _input.Length; i++)
                _input[i] = int.Parse(Console.ReadLine());
        }

        static void process(int[] _input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != _input.Length - 1; i++)
                {
                    if (_input[i] > _input[i + 1])
                    {
                        int temp = _input[i];
                        _input[i] = _input[i + 1];
                        _input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }

        static void output(int[] _input)
        {
            for (int i = 0; i != _input.Length; i++)
            {
                Console.Write(_input[i]);
                Console.Write(" ");
            }
        }
    }
}
