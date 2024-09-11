using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;

            size = 10;
            for (int i = 0; i < size; i++) // сверху вниз
            {
                for (int j = 0; j < size; j++) // справа налево
                {
                    if (j == size / 2 - 1 - i || j == size - 1 - (i - size / 2)) Console.Write("/");
                    else if (i == size / 2 + j || j == size / 2 + i) Console.Write("\\");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ромб\n");

            size = 5;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1) Console.Write("+ ");
                    else Console.Write("- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Шахматная доска\n");


            Console.Write("Введите размер шахматной доски: ");
            size = 7;
            //size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //for (int i = 0; i < 255; i++) Console.Write(Convert.ToChar(i));
            //┌ ─ ┐│└ ┘
            Console.Write("┌─");
            for (int i = 0; i < size; i++) Console.Write("──");
            Console.Write("─┐");
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write("│ ");

                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green; //фон
                        Console.ForegroundColor = ConsoleColor.White; //текст
                    }
                    else Console.ResetColor(); //сбросить настройки цвета                 
                    Console.Write("  ");
                }
                Console.ResetColor();
                Console.Write(" │");
                Console.WriteLine();
            }
            Console.Write("└─");
            for (int i = 0; i < size; i++) Console.Write("──");
            Console.Write("─┘");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Цветная шахматная доска\n");


            Console.Write("Введите размер шахматной доски: ");
            //size = Convert.ToInt32(Console.ReadLine());
            size = 4;
            int SQUARE_SIZE = 4;
            Console.WriteLine();

            for (int i = 0; i < size * SQUARE_SIZE; i++) // сверху вниз
            {
                for (int j = 0; j < size * SQUARE_SIZE; j++) // справа налево
                {

                    if (i / SQUARE_SIZE % 2 == 0 && j / SQUARE_SIZE % 2 == 0 || i / SQUARE_SIZE % 2 == 1 && j / SQUARE_SIZE % 2 == 1) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Большая шахматная доска из символов");
        }
    }
}