//Описание: Задайте двумерный массив целых чисел. Напишите программу, которая находит максимальный элемент в каждой строке массива и выводит его.
using System;

class Program
{
    static int[,] FillMatrix(int row, int col)
    {
        int[,] matrix = new int[row, col];
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(1, 10);
            }
        }
        return matrix;
    }

    static void ShowMatrix(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    /*static void FindMaxInRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int max = 0;
        // Введите свое решение ниже
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (max < array[i, j])
                {
                    max = array[i, j];
                }
            }
            System.Console.WriteLine($"Максимальный элемент в строке {i}: {max}");
            max = 0;
        }
    }*/
    static void FindSumInColumns(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int sum = 0;
        // Введите свое решение ниже
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                sum = sum + array[j, i];
            }
            System.Console.WriteLine($"Сумма элементов в столбце {i}: {sum}");
            sum = 0;
        }
    }
    static void Main()
    {
        System.Console.Write("Введите размерность массива через пробел: ");
        var lst0 = Console.ReadLine()?.Split().Select(int.Parse).ToList();
        int y1 = lst0[0];
        int y2 = lst0[1];
        int[,] matrix = FillMatrix(y1, y2);
        ShowMatrix(matrix);
        System.Console.WriteLine();
        //FindMaxInRows(matrix);
        FindSumInColumns(matrix);
    }
}

