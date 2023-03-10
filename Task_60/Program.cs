// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

int[,,] matrix3D = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(matrix3D);
Console.ReadLine();

int[,,] CreateMatrix(int a, int b, int c, int min, int max)
{
    int[,,] matrix = new int[a, b, c];
    
    for (int n = 0; n < matrix.GetLength(0); n++) // matrix.GetLength(0) - кол-во массивов
    {
        for (int i = 0; i < matrix.GetLength(1); i++) // matrix.GetLength(1) - кол-во строк
        {
            for (int j = 0; j < matrix.GetLength(2); j++) // matrix.GetLength(2) - кол-во столбцов
            {
                matrix[n, i, j] = new Random().Next(min, max + 1);
            }
        
        }
    }
    return matrix;
}
void PrintMatrix(int[,,] inMatrix)
{
    for (int n = 0; n < inMatrix.GetLength(0); n++)
    {
        for (int i = 0; i < inMatrix.GetLength(1); i++)
        {
            for (int j = 0; j < inMatrix.GetLength(1); j++)
            {
                Console.Write($"{inMatrix[n, i, j]} ({n}, {i}, {j}) ");
            }
            Console.WriteLine();
        }
    }
}

