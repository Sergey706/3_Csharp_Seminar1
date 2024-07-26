/*Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.*/
//System.Console.Write($"{number}");
// Задача 1
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0) System.Console.WriteLine("=> да");
else System.Console.WriteLine("=> нет");*/

//Задача 2
Console.Write("Введите число для координаты х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для координаты У: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0) 
{
    if (x>0 && y>0) System.Console.WriteLine("=> 1");
    if (x<0 && y>0) System.Console.WriteLine("=> 2");
    if (x<0 && y<0) System.Console.WriteLine("=> 3");
    if (x>0 && y<0) System.Console.WriteLine("=> 4");
}
else System.Console.WriteLine("Введите координаты отличные от нуля");

