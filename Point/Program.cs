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
                     SetX(value);//SetX(x);        ?????
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
                    SetY(value);//SetY(y);         ?????
                    //if (value > 700) value = 700;
                    //if (value < 0) value = 0;
                    //y = value;
                }
            }
            public Point(double x = 0, double y = 0)
            {
                this.X = x;
                this.Y = y;
            }
            public Point(Point obg)
            {
                this.X = obg.X;
                this.y = obg.y;
            }


            public void Print()
            {
                Console.WriteLine($"Координаты точки: X = {x}\tY = {y}");
            }
            public double Distance(Point other)//от текущей до указанной
            {
                return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));//Pov(основание,степень)
            }
            public static double Distance(Point first, Point second) //между двумя
            {
                return first.Distance(second);
            }
            public static Point operator +(Point A, Point B)
            {
                return new Point(A.X + B.X, A.Y + B.Y);
            }
            public static Point operator -(Point A, Point B)
            { return new Point(A.X - B.X, A.Y - B.Y); }//=>
            public static Point operator ++(Point point)
            {
                point.x++;
                point.y++;
                return point;
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(2, 6000);
            Point B = new Point(7, 11);
            A.Print();
            A.SetY(4000);
            A.X = 5;
            A.Print();
            B.Print();
            Console.WriteLine();
            Console.WriteLine($"от 'A' до 'B': {A.Distance(B)}");
            Console.WriteLine();
            Console.WriteLine($"между 'A' и 'B': {Point.Distance(A, B)}");
            Console.WriteLine();
            Point C = new Point(B - A);
            C.Print(); 
            ++C;
            C.Print(); 
        }
    }
}
