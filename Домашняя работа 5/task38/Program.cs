// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[6];
Random rand = new Random();
double max = array[0];
double min = array[0];
double res;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble() * 10;
    if (max < array[i]) max = array[i];
    if (array[i] < min) min = array[i];

}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Максимальное число в массиве = {max}");
Console.WriteLine($"Минимальное число в массиве = {min}");
res = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {res}");
//Console.WriteLine($"{string.Join(", ", array.Select(x => Math.Round(x, 2)))}"); Если нужно округлить числа в массиве типа double