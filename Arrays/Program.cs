using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 30;
            int[] arr = new int[n];
            Random rand = new Random(0);
            //foreach (int i in arr) //здесь нельзя
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
                //i = rand.Next(100);
            }
            foreach (int i in arr) //for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write(arr[i] + "\t");
                Console.Write(i + "\t");
            }
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
            Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");
            Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");


            Console.WriteLine(); Console.WriteLine();

            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] arr1 = new int[rows, cols];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = rand.Next(100);
                }
            }
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (int i in arr1)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine($"Количество измерений массива: {arr1.Rank}");
            Console.WriteLine($"Количество строк: {arr1.GetLength(0)}");
            Console.WriteLine($"Количество столбцов: {arr1.GetLength(1)}");
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива: {arr1.Cast<int>().Sum()}");
            Console.WriteLine($"Среднее-арифметическое элементов массива: {arr1.Cast<int>().Average()}");
            Console.WriteLine($"Минимальное значение в массиве: {arr1.Cast<int>().Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {arr1.Cast<int>().Max()}");
            Console.WriteLine(); Console.WriteLine();

            int[][] arr2 = new int[][]
                {
                    new int[]{ 0, 1, 1 },
                    new int[]{ 2, 3, 5, 8 },
                    new int[]{ 13 },
                    new int[]{ 21, 34, 55 ,4 }
                };
            int sum = 0;
            int length2 = 0;
            double cast = 0;
            int min = arr2[0][0];
            int max = arr2[0][0];
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + "\t");
                    sum += arr2[i][j];
                    length2++;
                    if (min > arr2[i][j]) min = arr2[i][j];
                    if (max < arr2[i][j]) max = arr2[i][j];
                }
                Console.WriteLine();
            }
            cast = Convert.ToDouble(sum) / Convert.ToDouble(length2);
            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Количество элементов массива: {length2}");
            Console.WriteLine($"Среднее-арифметическое элементов массива: {cast}");
            Console.WriteLine($"Минимальное значение в массиве: {min}");
            Console.WriteLine($"Максимальное значение в массиве: {max}");
            Console.WriteLine(); Console.WriteLine();

        }
    }
}
