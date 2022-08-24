// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4
Console.WriteLine("Введите количество чисел для выборки");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];
Console.WriteLine("Введите числа для дальнейшей выборки");
int count = 0;

for (int i = 0; i < arr.Length; i++)  
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if(arr[i] > 0) count++; 
}

Console.WriteLine($"Количество чисел больше 0: {count}");