using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static int process(int i)
        {
            int result;
            if(i > 1)
            {
                result = i * process(i - 1);
            } else
            {
                result = 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int j;
            Console.WriteLine("put your number");
           
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("result = "+process(j));
            Console.ReadKey();
        }
    }
}
