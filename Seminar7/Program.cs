// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, 
//не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //System.Console.Write("Задайте значения M < N через пробел: ");
        System.Console.Write("Введите размерность массива через пробел: ");
        var lst0 = Console.ReadLine()?.Split().Select(int.Parse).ToList();
        int y1 = lst0[0];
        int y2 = lst0[1];
        int[] arr = FillMatrix(y2);
        ShowMatrix(arr);
        System.Console.Write("\nВ обратном порядке: ");
        int n = arr.Length;
        RecursMatrix(n-1);

        void RecursMatrix(int n)
        {
            if (n < 0) return;
            Console.Write($"{arr[n]} ");
            RecursMatrix(n-1); 
        }
        /*void OutNumber(int m, int n)
        {
            if (m == n) {
                Console.Write(m);
                return;
            }
            Console.Write($"{m}, ");
            OutNumber(m + 1, n);
        }
        OutNumber(y1, y2);*/
        /*
        int Ackkerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if ((m > 0) && (n == 0))
            {
                return Ackkerman(m - 1, 1);
            }
            return Ackkerman(m - 1, Ackkerman(m, n - 1));
        }
        Console.Write(Ackkerman(y1, y2));*/

        static int[] FillMatrix(int col)
        {
            int[] matrix = new int[col];
            Random rnd = new Random();
            for (int i = 0; i < col; i++)
            {
                matrix[i] = rnd.Next(0, 10);
            }
            return matrix;
        }
        static void ShowMatrix(int[] matr)
        {
            for (int i = 0; i < matr.Length; i++)
            {
                Console.Write($"{matr[i]} ");
            }
        }
    }
}