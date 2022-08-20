// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[6];
Random rand = new Random();
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 101);
    if (max < array[i]) max = array[i];
}
Console.WriteLine(string.Join(", ", array));
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
}

Console.WriteLine(max);
Console.WriteLine(min);
int res = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {res}");