// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[9];
Random rand = new Random();
int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 101);
    if (i % 2 != 0)
    {
        Sum += array[i];
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях = {Sum}");