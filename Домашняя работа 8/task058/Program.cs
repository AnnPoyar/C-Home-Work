// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = new int [,] {{3, -1, 5, 8},{2, 1, 0, 4}};
int[,] matr = new int [,] {{1, 8, -5, 0},{3, 6, -7, 8}};
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matr);
Console.WriteLine();
int[,] NewMatrix = new int[2, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        NewMatrix[i,j] = matrix[i,j] * matr[i,j];
    }
    
}

PrintMatrix(NewMatrix);