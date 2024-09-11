using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("█");
            ConsoleKey key;// char
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(Convert.ToChar(key));
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
