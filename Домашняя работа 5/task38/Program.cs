// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[6];
Random rand = new Random();
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 101);
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(min);
Console.WriteLine(max);
int res = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {res}");