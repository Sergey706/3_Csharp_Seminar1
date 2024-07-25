// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Задача 1: Напишите программу, которая на вход принимает два
числа и выдаёт, какое число большее, а какое меньшее.
a=5;b=7 => max=7, min=5
a=2;b=10 => max=10, min=2
a=-9;b=-3 => max=-3, min=-9
Задача 2: Напишите программу, которая принимает на вход три
числа и выдаёт максимальное из этих чисел.
2, 3, 7 => 7
44, 5, 78 => 78
22, 3, 9 => 22
Задача 3: Напишите программу, которая на вход принимает число и
выдаёт, является ли число чётным.
4 => да
-3 => нет
7 => нет
Задача 4: Напишите программу, которая на вход принимает число
(N), а на выходе показывает все чётные числа от 1 до N.
5 => 2, 4
8 => 2, 4, 6, 8
*/

//Задача 1
/*using System.Runtime.InteropServices.Marshalling;

int firstValue = 25;
int secondValue = 25;

if (firstValue > secondValue)
{
    System.Console.Write($"max={firstValue}, min={secondValue}");
}
else if (firstValue < secondValue) System.Console.Write($"max={secondValue}, min={firstValue}");
    else System.Console.Write($"числа {firstValue} и {secondValue} равны");*/

//Задача 2
/*
int firstValue = 25;
int secondValue = 15;
int thirdValue = 35;

    if (firstValue >= secondValue && firstValue >= thirdValue)
    {
        System.Console.Write($" => {firstValue}");
    }
    else
    {
        if (secondValue >= firstValue && secondValue >= thirdValue) System.Console.Write($" => {secondValue}");
         else System.Console.Write($" => {thirdValue}");
    }*/

//Задача 3
/*int number = 24;
    if (number % 2 == 0)
    {
        System.Console.WriteLine($"четное");
    }
    else System.Console.WriteLine($"нечетное");
*/

//Задача 4
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.Write($"{i} ");
            }
        }
