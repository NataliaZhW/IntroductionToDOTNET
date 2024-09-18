//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        class Fraction
        {
            public int Integer { get; set; }
            public int Numerator { get; set; }

            int denominator;
            public int Denominator
            {
                get => denominator;
                set => denominator = value == 0 ? 1 : value;
            }
            public Fraction()
            {
                //Console.WriteLine("DefConstructor:\t" + GetHashCode());
            }
            public Fraction(int integer)
            {
                Integer = integer;
                //Console.WriteLine("Constructor:\t" + GetHashCode());
            }
            public Fraction(int numerator, int denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
                //Console.WriteLine("Constructor:\t" + GetHashCode());
            }
            public Fraction(int integer = 0, int numerator = 0, int denominator = 1)
            {
                Integer = integer;
                Numerator = numerator;
                Denominator = denominator;
                //Console.WriteLine("Constructor:\t" + GetHashCode());
            }
            public Fraction(Fraction obj)
            {
                this.Integer = obj.Integer;
                this.Numerator = obj.Numerator;
                this.Denominator = obj.Denominator;
                //Console.WriteLine($"CopyConstructor:{GetHashCode()}");
            }
            ~Fraction()
            {
                //Console.WriteLine("Destructor:\t" + GetHashCode());
            }
            //			   Operators:
            public static Fraction operator *(Fraction l, Fraction r)
            {
                Fraction left = l.Improper();
                Fraction right = r.Improper();
                Fraction res = new Fraction
                    (
                    left.Numerator * right.Numerator,
                    left.Denominator * right.Denominator
                    );
                return res;
            }
            public static Fraction operator /(Fraction left, Fraction right)
            {
                return left * right.Inverted();
            }
            public Fraction Inverted() // обратная
            {
                Fraction inverted = new Fraction(this);
                inverted.Improper();
                int buffer = inverted.Numerator;
                inverted.Numerator = inverted.Denominator;
                inverted.Denominator = buffer;
                return inverted;
            }


            // ????? Неявно перегружены +=, -=, *=, /=;

            public static Fraction operator +(Fraction l, Fraction r)
            {
                Fraction left = l.Improper();
                Fraction right = r.Improper();
                Fraction res = new Fraction
                    (
                    left.Numerator * right.Denominator + right.Numerator * left.Denominator,
                    left.Denominator * right.Denominator
                    );
                return res;
            }            
            public static Fraction operator -(Fraction l, Fraction r)
            {
                Fraction left = l.Improper();
                Fraction right = r.Improper();
                Fraction res = new Fraction
                    (
                    left.Numerator * right.Denominator - right.Numerator * left.Denominator,
                    left.Denominator * right.Denominator
                    );
                return res;
            }

            public static Fraction operator ++(Fraction obj) //
            {
                return new Fraction(obj.Integer + 1, obj.Numerator, obj.Denominator);
            }             
            public static Fraction operator --(Fraction obj) //
            {
                return new Fraction(obj.Integer - 1, obj.Numerator, obj.Denominator);
            }
            public static bool operator ==(Fraction left, Fraction right) 
            {
                return (left.Integer == right.Integer && left.Numerator == right.Numerator 
                    && left.Denominator == right.Denominator);
                
            }
            public static bool operator !=(Fraction left, Fraction right) 
            {
                return (left.Integer != right.Integer || left.Numerator != right.Numerator
                    || left.Denominator != right.Denominator);
            }
            public static bool operator >(Fraction l, Fraction r) 
            {
                Fraction left = l.Improper();
                Fraction right = r.Improper();                
                return (left.Numerator * right.Denominator > right.Numerator * left.Denominator);
            }
            public static bool operator <(Fraction l, Fraction r) 
            {
                Fraction left = l.Improper();
                Fraction right = r.Improper();
                return (left.Numerator * right.Denominator < right.Numerator * left.Denominator);
            }
            public static bool operator >=(Fraction l, Fraction r)
            {
                Fraction left = l.Improper();
                Fraction right = r.Improper();
                return (left.Numerator * right.Denominator >= right.Numerator * left.Denominator);
            }
            public static bool operator <=(Fraction l, Fraction r)
            {
                Fraction left = l.Improper();
                Fraction right = r.Improper();
                return (left.Numerator * right.Denominator <= right.Numerator * left.Denominator);
            }
            //				Methods:
            public Fraction Proper() // перевести в правильноую
            {
                Fraction copy = new Fraction(this);
                copy.Integer += copy.Numerator / copy.Denominator;
                copy.Numerator %= copy.Denominator;
                return copy;
            }
            public Fraction Improper() // перевести в неправильную
            {
                Fraction copy = new Fraction(this);
                copy.Numerator += copy.Integer * copy.Denominator;
                copy.Integer = 0;
                return copy;
            }

            public Fraction Reduce()//сокращение
            {                
                int more, less, rest;
                if (this.Numerator > this.Denominator)
                {
                    more = this.Numerator; less = this.Denominator;
                }

                else { more = this.Denominator; less = this.Numerator; }
                do
                {
                    rest = more % less;
                    more = less;
                    less = rest;
                } while (Convert.ToBoolean(rest));
                int GCD = more; //GCD - Greatest Common Divesor
                Console.WriteLine($"GCD = {GCD}");//

                this.Numerator /= GCD;
                this.Denominator /= GCD;
                return this;
            }
            public void Print()
            {
                //Reduce();
                if (Integer != 0) Console.Write(Integer);
                if (Numerator != 0)
                {
                    if (Integer != 0) Console.Write("(");
                    Console.Write($"{Math.Abs(Numerator)}/{Math.Abs(Denominator)}");
                    //Math.Abs(value)
                    if (Integer != 0) Console.Write(")");
                }
                else if (Integer == 0) Console.Write(0);
                Console.WriteLine();
            }
            public override string ToString()
            {

                string print = "";
                if (Integer != 0) print += Convert.ToString(Integer);
                if (Numerator != 0)
                {
                    if (Integer != 0) print += "(";
                    print += Convert.ToString(Numerator / Denominator);
                    //print += $"{Numerator}/{Denominator}";
                    if (Integer != 0) print += ")";
                }
                else if (Integer == 0) print += "0";
                return print;
            }
        }
        static void Main(string[] args)
        {

#if CONSTRUCTORS_CHECK

            Fraction A = new Fraction();
            A.Print();
            Console.WriteLine(A);

            Fraction B = new Fraction(5);
            B.Print();
            Console.WriteLine(B);

            Fraction C = new Fraction(1, 2);
            C.Print();
            Console.WriteLine(C);

            Fraction D = new Fraction(2, 3, 4);
            D.Print();
            Console.WriteLine(D);
#endif //CONSTRUCTORS_CHECK

            Fraction A1 = new Fraction(2, 1, 4);
            A1.Print();
            Fraction B1 = new Fraction(3, 1, 2);
            B1.Print();
            Console.WriteLine();

            Fraction C1 = new Fraction(A1 * B1);
            C1.Print();
            Fraction C2 = new Fraction(A1 / B1);
            C2.Print();

            Fraction D1 = new Fraction(A1 + B1);
            //D1.Print();
            D1.Reduce();
            D1.Proper().Print();
            D1.Print();
            Fraction D2 = new Fraction(A1 - B1);
            //D2.Print(); 
            D2.Reduce();
            D2.Proper().Print();
            Console.WriteLine();

            Fraction E1 = new Fraction(A1);
            //Console.WriteLine(A1==E1);
            ++E1; 
            E1.Proper().Print(); 
            Fraction E2 = new Fraction(A1);
            --E2; 
            E2.Proper().Print();
            Console.WriteLine();

            Console.WriteLine(A1==B1);
            Console.WriteLine(A1!=B1);  
            Console.WriteLine(A1>B1);
            Console.WriteLine(A1<B1); 
            Console.WriteLine(A1>=B1);
            Console.WriteLine(A1<=B1);
            Console.WriteLine();

            Fraction F1 = new Fraction(A1);
            F1+=E1;
            F1.Proper().Print();
            Fraction F2 = new Fraction(A1);
            F2 -= E2;
            F2.Proper().Print();
            Console.WriteLine();

            //A1.Print();            
        }

    }
}
