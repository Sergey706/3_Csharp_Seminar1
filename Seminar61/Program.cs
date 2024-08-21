Main();
static void ShowMatrix(char[,] matr)
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
//Задача 1: Задайте двумерный массив символов (тип char[,]). Создать строку из символов этого массива
/*void Main()
{
    Char[,] lett = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
    String a = "";
    foreach (char e in lett)
    {
        a = a + e;
    }
    ShowMatrix(lett);
    System.Console.WriteLine($"=> {a}");
}*/
//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные
/*
void Main()
{
    System.Console.Write("Введите строку: ");
    string? row = Console.ReadLine();
    System.Console.WriteLine($"=> {row.ToLower()}");
}*/
//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом
/*void Main()
{
    System.Console.Write("Введите строку: ");
    string? row = Console.ReadLine();
    System.Console.WriteLine($"=> {row.ToLower()}");
    if (row[0] == row[row.Length-1] && row[1] == row[row.Length-2]){
        System.Console.WriteLine("O yes!");
    }else System.Console.WriteLine("Sorry");
}*/

//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку,
//в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами
string[] ConvertArray(string[] arr)
{
    String temp = "";
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
    return arr;
}
void Main()
{
    System.Console.Write("Введите строку, разделенную пробелами: ");
    string row = Console.ReadLine();
    string row1 = "";
    string[] rowArray = row.Split(" ");
    string[] rowArray1 = new string[rowArray.Length];
    rowArray1 = ConvertArray(rowArray);
    System.Console.WriteLine($"=> ");
    foreach (string ch in rowArray1)
    {
        row1 = row1 + ch + " ";
    }
    System.Console.WriteLine(row1);
}
