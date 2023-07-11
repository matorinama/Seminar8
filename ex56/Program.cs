/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Clear();
Console.Write("Введите количестов строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количестов столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] matrix = GetMatrix(row, column, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
MinSumRows(matrix);


void MinSumRows(int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            sum[m] += matr[m, n];
        }
    }
    int min = sum[0];
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < min) min = sum[i];
    }
    Console.WriteLine(min);
}


void PrintMatrix(int[,] matr)
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
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}