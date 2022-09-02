// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}
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


void MinSumOfElementsOnRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[i, j];
        }
        array[i] = Sum;
        Console.WriteLine($"Сумма элементов в строках массива = {array[i]}");
    }
    Console.WriteLine();
    int minRowElement = array[0];
    int minRowIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (minRowElement > array[i])
        {
            minRowElement = array[i];
            minRowIndex = i;
        }
    }
   Console.WriteLine($"В строке {minRowIndex} наименьшая сумма элементов {minRowElement}");
}



Console.Write("Введите m и n через Enter ");
int m = Convert.ToInt32(Console.ReadLine());//число строк
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matr = FillMatrix(m, n);
if (m != n)
{
    PrintMatrix(matr);
    Console.WriteLine();
    MinSumOfElementsOnRow(matr);
}
else Console.WriteLine("Неверно заданы параметры");