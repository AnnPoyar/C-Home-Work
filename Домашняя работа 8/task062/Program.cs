// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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


Console.Write("Введите количество строк и количество столбцов через Enter ");
int Rows = Convert.ToInt32(Console.ReadLine());//число строк
int Columns = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = new int[Rows, Columns];
Console.Write("Введите первое число");
int digit = Convert.ToInt32(Console.ReadLine());//начало заполнения массива
int i = 0, k = 0, j;
while (i < Rows * Columns)
{
    k++;
    for (j = k - 1; j < Columns - k + 1; j++)
    {
        matrix[k - 1, j] = digit++;
        i++;
    }
    for (j = k; j < Rows - k - 1; j++)
    {
        matrix[j, Columns - k] = digit++;
        i++;
    }
    for (j = Columns - k - 1; j >= k - 1; j--)
    {
        matrix[Rows - k, j] = digit++;
        i++;
    }
    for (j = Rows - k - 1; j >= k; j--)
    {
        matrix[j,k-1] = digit ++;
    }
}
Console.Write(matrix[Rows, Columns]);