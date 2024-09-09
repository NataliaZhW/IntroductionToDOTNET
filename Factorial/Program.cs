using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.CodeDom.Compiler;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.Write("Введите число: ");// ulong <20; 
            x = Convert.ToInt32(Console.ReadLine());
            //ulong f = Factorial(x);
            Console.WriteLine("Факториал " + x + " = " + Factorial(x));
            Console.WriteLine();
            int n = 1000;
            Console.WriteLine("Факториал " + n + " = " + FactorialBig(n));
            Console.WriteLine();
        }

        static ulong Factorial(int x)
        {
            ulong f = 1;
            for (int i = 1; i <= x; i++) { f *= Convert.ToUInt64(i); } // Console.WriteLine(f);
            return f;
        }
        static BigInteger FactorialBig(int x)
        {
            BigInteger f = 1;
            for (int i = 1; i <= x; i++)
            {
                f *= i;  
                //Console.WriteLine(f);                 
            }
            return f;
        }
    }
}
