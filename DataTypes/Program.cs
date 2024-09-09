//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter1 = "\n----------------------------------------------\n";
        static readonly string delimiter2 = "\n==============================================\n";
        static void Main(string[] args)
        {
#if NUMERIC_TYPES
            Console.WriteLine("C# DataTypes");

            #region Boolean
            Console.WriteLine(bool.TrueString);
            Console.WriteLine(Convert.ToBoolean(100));
            Console.WriteLine(bool.Parse("falsE"));

            #endregion

            //Unicode

            Console.WriteLine($"Переменная типа 'short' занимает {sizeof(short)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {short.MinValue} ... {short.MaxValue}");
            Console.WriteLine($"Диапазон принимаемых значений 'ushort': {ushort.MinValue} ... {ushort.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'Int16' занимает {sizeof(Int16)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {Int16.MinValue} ... {Int16.MaxValue}");
            Console.WriteLine($"Диапазон принимаемых значений 'UInt16': {UInt16.MinValue} ... {UInt16.MaxValue}");
            Console.WriteLine(delimiter2);

            Console.WriteLine($"Переменная типа 'int' занимает {sizeof(int)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {int.MinValue} ... {int.MaxValue}");
            Console.WriteLine($"Диапазон принимаемых значений 'uint': {uint.MinValue} ... {uint.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'Int32' занимает {sizeof(Int32)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {Int32.MinValue} ... {Int32.MaxValue}");
            Console.WriteLine($"Диапазон принимаемых значений 'UInt16': {UInt32.MinValue} ... {UInt32.MaxValue}");
            Console.WriteLine(delimiter2);

            Console.WriteLine();Console.WriteLine($"Переменная типа 'long' занимает {sizeof(long)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {long.MinValue} ... {long.MaxValue}");
            Console.WriteLine($"Диапазон принимаемых значений 'ulong': {ulong.MinValue} ... {ulong.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'Int64' занимает {sizeof(Int64)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {Int64.MinValue} ... {Int64.MaxValue}");
            Console.WriteLine($"Диапазон принимаемых значений 'UInt64': {UInt64.MinValue} ... {UInt64.MaxValue}");
            Console.WriteLine(delimiter2);
            Console.WriteLine();
            
            Console.WriteLine();Console.WriteLine($"Переменная типа 'float' занимает {sizeof(float)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {float.MinValue} ... {float.MaxValue}");
            //Console.WriteLine($"Диапазон принимаемых значений 'ufloat': {ufloat.MinValue} ... {ufloat.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'double' занимает {sizeof(double)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {double.MinValue} ... {double.MaxValue}");
            //Console.WriteLine($"Диапазон принимаемых значений 'double': {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine(delimiter2);
            Console.WriteLine();
            
            Console.WriteLine($"Переменная типа 'decimal' занимает {sizeof(decimal)} байта");
            Console.WriteLine($"и принимает значения в диапазоне: {decimal.MinValue} ... {decimal.MaxValue}");
            //Console.WriteLine($"Диапазон принимаемых значений 'decimal': {decimal.MinValue} ... {double.MaxValue}");
            Console.WriteLine(delimiter2);
            Console.WriteLine();
#endif //NUMERIC_TYPES

#if LITERALS
            Console.WriteLine(123.GetType()); //int
            Console.WriteLine(123.4f.GetType()); //float
            Console.WriteLine(123f.GetType()); //float
            Console.WriteLine(123.4.GetType()); //doufle
            Console.WriteLine(123.4m.GetType());
#endif //LITERALS
            Console.WriteLine(((byte)5).GetType()); //int
            Console.WriteLine((5).GetType().Name); //int
        }
    }
}
