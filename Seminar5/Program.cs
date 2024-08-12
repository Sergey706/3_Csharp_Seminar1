// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца.
//Задача №1
int[,] FillMatrix(int row, int col)
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

void ShowMatrix(int[,] matr)
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
/*
void Main()
{
    System.Console.Write("Введите размерность массива через пробел: ");
    var lst0 = Console.ReadLine()?.Split().Select(int.Parse).ToList();
    int y1 = lst0[0];
    int y2 = lst0[1];
    int[,] matrix = FillMatrix(y1, y2);
    ShowMatrix(matrix);
    System.Console.Write("Введите позиции элемента через пробел: ");
    var lst = Console.ReadLine()?.Split().Select(int.Parse).ToList();
    int x1 = lst[0];
    int x2 = lst[1];
    Console.Write($"({x1}, {x2}) => ");
    if (x1 >= y1 || x2 >= y2) System.Console.WriteLine("Такого элемента нет");
    else System.Console.WriteLine($"{matrix[x1,x2]}");
}*/
Main();

//Задача №2
void Main()
{
    System.Console.Write("Введите размерность массива через пробел: ");
    var lst0 = Console.ReadLine()?.Split().Select(int.Parse).ToList();
    int y1 = lst0[0];
    int y2 = lst0[1];
    int[,] matrix = FillMatrix(y1, y2);
    ShowMatrix(matrix);
    System.Console.WriteLine("=>");
    ChangeMatrix(matrix);
    ShowMatrix(matrix);
}

int[,] ChangeMatrix(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0,i];
        matr[0, i] = matr[matr.GetLength(0) - 1,  i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
    return matr;
}

//Задача №3