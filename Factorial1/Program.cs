using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial1
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
            //Console.WriteLine("Факториал " + n + " = " + FactorialBig(n));
            //Console.WriteLine();

            ulong f1 = 1;
            try
            {
                for (int i = 1; i <= x; i++)
                {
                    f1 *= Convert.ToUInt64(i);  // Console.WriteLine(f);
                    Console.WriteLine("Факториал " + i + " = " + f1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static ulong Factorial(int x)
        {
            ulong f = 1;
            //try
            //{
            for (int i = 1; i <= x; i++) { f *= Convert.ToUInt64(i); } // Console.WriteLine(f);
            return f;
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
        }
        //static BigInteger FactorialBig(int x)
        //{
        //    BigInteger f = 1;
        //    for (int i = 1; i <= x; i++)
        //    {
        //        f *= i;
        //        //Console.WriteLine(f);                 
        //    }
        //    return f;
        //}
    }
}