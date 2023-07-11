/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int column1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int column2 = int.Parse(Console.ReadLine());
int[,] matr1 = GetArray(row1, column1, 0, 9);
int[,] matr2 = GetArray(row2, column2, 0, 9);
PrintArray(matr1);
Console.WriteLine();
PrintArray(matr2);
Console.WriteLine();
if (column1 != row2)
{
    Console.WriteLine("Невозможно умножить");
    return;
}

PrintArray(PowMatrix(matr1, matr2));


int[,] PowMatrix(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


