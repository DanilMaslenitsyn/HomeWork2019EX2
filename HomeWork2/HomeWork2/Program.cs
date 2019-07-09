using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a =");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b =");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c =");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = MIN(a, b, c);
            Console.Write(min);
            Console.ReadLine();
        }

        private static int MIN(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                if (b < c) { min = b; }
                else { min = c; }

            }
            return min;
        }
    }
}
