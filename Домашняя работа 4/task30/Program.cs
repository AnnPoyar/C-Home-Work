// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Вводим массив через консоль

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число массива [i=0]: ");
int index0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число массива [i=1]: ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число массива [i=2]: ");
int index2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число массива [i=3]: ");
int index3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число массива [i=4]: ");
int index4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число массива [i=5]: ");
int index5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число массива [i=6]: ");
int index6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число массива [i=7]: ");
int index7 = Convert.ToInt32(Console.ReadLine());
int[]Array = new int[8];
Array[0] = index0;
Array[1] = index1;
Array[2] = index2;
Array[3] = index3;
Array[4] = index4;
Array[5] = index5;
Array[6] = index6;
Array[7] = index7;
PrintArray(Array);



