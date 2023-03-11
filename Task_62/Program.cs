// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;

Clear();

Write("Введите размер массива: ");
int size = int.Parse(ReadLine());


int[,] array1 = GetSpirale(size);
Printresult(array1);
WriteLine();


int[,] GetSpirale(int n)
{
    int[,] result = new int[n, n];
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { result[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) result[i++, j] = value++;
        for (k = 0; k < n - 1; k++) result[i, j--] = value++;
        for (k = 0; k < n - 1; k++) result[i--, j] = value++;
        ++i; ++j;//при этом отсчет начинается с единицы но не с нуля
        n = n < 2 ? 0 : n - 2;
    }
    return result;
}

void Printresult(int[,] inresult)
{
    for (int i = 0; i < inresult.GetLength(0); i++)
    {
        for (int j = 0; j < inresult.GetLength(1); j++)
        {
            Write($"{inresult[i, j]} ");
        }
        WriteLine();
    }
}