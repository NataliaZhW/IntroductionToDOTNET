using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Program
    {
        class Point
        {
            double x, y;
            public double GetX() { return x; }
            public double GetY() { return y; }
            public void SetX(double x)
            {
                if (x > 1000) x = 1000;
                if (x < 0) x = 0;
                this.x = x;
            }
            public void SetY(double y)
            {
                if (y > 700) y = 700;
                if (y < 0) y = 0;
                this.y = y;
            }
            public double X
            {
                get { return x; }
                set
                {
                    //SetX(x); SetX(value);        ?????
                    if (value > 1000) value = 1000;
                    if (value < 0) value = 0;
                    x = value;
                }
            }
            public double Y
            {
                get { return y; }
                set
                {
                    //SetY(y); SetY(value);        ?????
                    if (value > 700) value = 700;
                    if (value < 0) value = 0;
                    y = value;
                }
            }
            public Point(double x = 0, double y = 0)
            {
                this.x = x;
                this.y = y;
            }
           
            public void print()
            {
                Console.WriteLine($"Координаты точки: X = {x}\tY = {y}");
            }
            public double distance(Point other)//от текущей до указанной
            {
                return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));//Pov(основание,степень)
            }
            public static double distance(Point first, Point second) //между двумя
            {
                return first.distance(second);
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(2, 6);
            Point B = new Point(7, 11);
            A.print();
            A.SetY(4);
            A.X = 5;
            A.print();
            B.print();
            Console.WriteLine();
            Console.WriteLine($"от 'A' до 'B': {A.distance(B)}");
            Console.WriteLine();
            Console.WriteLine($"между 'A' и 'B': {Point.distance(A, B)}");
            Console.WriteLine();

        }
    }
}
