/*
Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
*/

//Задача №1
/*
int[] arr1 = {12, 3, 56, 4, 45, 23, 3, 99, 88, 78};

int count = 0;
System.Console.Write("массив [");
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] > 20 && arr1[i] < 90) count++;
    System.Console.Write($"{arr1[i]}");
    if (i < arr1.Length-1) System.Console.Write(", ");
}
System.Console.WriteLine($"] => {count}");
*/
//Задача №2
/*
int[] arr1 = {12, 3, 56, 4, 45, 23, 3, 99, 88, 78};

int count = 0;
System.Console.Write("массив [");
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] % 2 == 0) count++;
    System.Console.Write($"{arr1[i]}");
    if (i < arr1.Length-1) System.Console.Write(", ");
}
System.Console.WriteLine($"] => {count}");
*/
//Задача №3

double[] arr1 = {12.4, 3.3, 56.0, 4.3, 45.8, 23.6, 3.5, 99.2, 88.1, 78.6};

double max = arr1[0];
double min = arr1[0];
System.Console.Write("массив [");
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] > max) max=arr1[i];
    if (arr1[i] < min) min=arr1[i];
    System.Console.Write($"{arr1[i]}");
    if (i < arr1.Length-1) System.Console.Write("; ");
}
System.Console.WriteLine($"] => {max-min}");

