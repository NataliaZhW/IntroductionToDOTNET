//#define OUTPUT_TO_SCREEN
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_TO_SCREEN
            Console.Title = "Introduction to .NET";
            Console.WriteLine("\t\t\tHello .NET");
            Console.BackgroundColor = ConsoleColor.Green; //Цвет фона
            Console.ForegroundColor = ConsoleColor.Black; //Цвет текста

            //Console.CursorLeft = 24;
            //Console.CursorTop = 5;

            Console.SetCursorPosition(16,5);
            Console.WriteLine("Вот так задаются координаты");

            Console.ResetColor(); //Цветовая схема по умолчанию

            #region Code
            //Console.WindowWidth = 44; //размеры окна
            //Console.WindowHeight = 16; 
            Console.SetWindowSize(44,16);
            #endregion

            //Console.WindowLeft = 10; //Position окна
            //Console.WindowTop = 10; 
            Console.SetWindowPosition(10,10);

            //Console.BufferWidth = Console.WindowWidth; //.. окна
            //Console.BufferHeight = Console.WindowHeight; 
            Console.SetBufferSize(44,16);
#endif //OUTPUT_TO_SCREEN

            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine(); //Читает строку до "ввода" и возвращает строку
            //Console.WriteLine(first_name);

            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            //Console.WriteLine(last_name);

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);
            Console.WriteLine(last_name + " " + first_name + " " + age + " years"); //Конкатенация

            Console.WriteLine(String.Format("{0} {1} {2} years", last_name , first_name, age));

            Console.WriteLine($"{last_name} {first_name} {age} years"); //Интерполяция
        }
    }
}
