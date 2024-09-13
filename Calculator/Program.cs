using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение:");
            int x = 2;
            int y = 2;
            int a = 0; // операнд 1
            int b = 0; // операнд 2
            char o = '+'; // оператор
            double res = 0; // результат

            ConsoleKey key;// char
            do
            {
                key = Console.ReadKey(true).Key;
                a = Convert.ToInt32(key);
                Console.SetCursorPosition(x, y);
                Console.WriteLine(a);

                //key = Console.ReadKey(true).Key;
                //o = Convert.ToChar(key);
                //Console.SetCursorPosition(x + 2, y);
                //Console.WriteLine(o);

                //key = Console.ReadKey(true).Key;
                //b = Convert.ToInt32(key);
                //Console.SetCursorPosition(x + 4, y);
                //Console.WriteLine(b);

                //Console.WriteLine(Convert.ToChar(key));
                //switch (o)
                //{
                //    case 'k':                    
                //        res = a+b ; break;
                //    case 'm':                    
                //        res = a - b; break;
                //    case 'j':                    
                //        res = a * b; break;
                //    case 'o':                   
                //        res = a / b; break;
                //    default: break;
                //}
                //Console.Clear();
                Console.SetCursorPosition(x, y+2);
                //Console.WriteLine("Результат " + res);
                Console.WriteLine("Результат " + a);
                Console.SetCursorPosition(0, 0);
            }
            while (key != ConsoleKey.Escape);
            //Console.WriteLine("Вот так задаются координаты");
            //Console.ResetColor(); //Цветовая схема по умолчанию
        }
    }
}