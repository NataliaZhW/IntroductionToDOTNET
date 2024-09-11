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

            Console.SetCursorPosition(x, y);
            ConsoleKey key;// char
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine("█");
                a = Convert.ToInt32(Console.ReadKey())
                Console.WriteLine(Convert.ToChar(key));
                switch (Convert.ToChar(key))
                {
                    case 'h':
                    case '&':
                        y--; break;
                    case 'b':
                    case '(':
                        y++; break;
                    case 'd':
                    case '%':
                        x--; break;
                    case 'f':
                    case '\'':
                        x++; break;
                    default: break;
                }
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("█");
                Console.SetCursorPosition(0, 0);
            }
            while (key != ConsoleKey.Escape);
            //Console.WriteLine("Вот так задаются координаты");
            //Console.ResetColor(); //Цветовая схема по умолчанию
        }
    }
}