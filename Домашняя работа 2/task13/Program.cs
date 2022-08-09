// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int[]array = {Console.ReadLine()};
int n = array.Length;
if(n >= 3)
{
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine(" Нет третьей цифры");
}