// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
//Задача №1
/*
void PrintMessage()
{
    System.Console.Write("Введите целое число: ");
}

bool GoToFinish(string a)
{
    if (Equals (a, "q")) return true;
    else{
        if (Chetno(a)) return true;
        else return false;
        }
}

bool Chetno(string a)
{
    int Value = Convert.ToInt32(a);
    int count = 0;
    int temp = Value;
    int n = 0;
    while (temp > 0)
    {
        temp = temp / 10;
        n++;
    }
    int[] arr1 = new int[n];
    while (Value > 0)
    {
        arr1[count] = Value % 10;
        Value = Value / 10;
        count++;
    }
    n = 0;
    foreach (int e in arr1)
    {
        n = n + e;
    }
    if (n % 2 == 0) return true;
    else return false;
}

string a = "1";
void AsckMessage(string Value)
{
    while (!GoToFinish(Value))
    {
        PrintMessage();
        Value = Convert.ToString(Console.ReadLine());
    }
    System.Console.WriteLine(" [STOP]");
}
AsckMessage(a);
*/

//Задача №2
/*using System.Runtime.InteropServices;

void PrintMessage()
{
    System.Console.Write("Введите размерность массива как целое число: ");
}
int GetValueChetno(int[] arr)
{
    int val = 0;
    foreach (int e in arr)
    {
        if (e % 2 == 0) val++;
    }
    return val;
}
int[] FillArray(int Value)
{
    int i = 0;
    int[] arr = new int[Value];
    Random rnd = new Random();
    while (i < Value)
    {
        arr[i] = rnd.Next(100, 999);
        i++;
    }
    i = 0;
    while (i < Value)
    {
        System.Console.Write($"{arr[i]} ");
        i++;
    }
    return arr;
}
PrintMessage();
int Value = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($" => {GetValueChetno(FillArray(Value))}");
*/
//Задача №3
void PrintMessage()
{
    System.Console.Write("Введите размерность массива как целое число: ");
}
int[] FillArray(int Value)
{
    int i = 0;
    int[] arr = new int[Value];
    Random rnd = new Random();
    while (i < Value)
    {
        arr[i] = rnd.Next(10, 99);
        i++;
    }
    return arr;
}
int[] ConvertArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
    return arr;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for(int i=0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}");
        if (i < arr.Length-1) System.Console.Write(", ");
    }
    System.Console.Write($"]");
}
PrintMessage();
int Value = Convert.ToInt32(Console.ReadLine());
int[] a = FillArray(Value);
PrintArray(a);
System.Console.Write(" => ");
PrintArray(ConvertArray(a));

