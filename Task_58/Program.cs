// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// То есть: 2*3 + 4*3 = 18(0,1-координаты в резул матрице) ; 2*4 + 4*3 =20(0,2) и т.д.Строка 1 матрицы умножается на столбец 2 матрицы

int[,] array2D = CreateMatrix(new Random().Next(2, 4), new Random().Next(2, 4), 1, 9);
int[,] matrix = CreateMatrix(new Random().Next(2, 4), new Random().Next(2, 4), 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(DivMatrix(array2D, matrix));
Console.ReadLine();

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] inArray)
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

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Невозможно получить произведение матриц");
        return new int[0,0]; // возвращает пустой массив
    }
    return matrix3;
}

