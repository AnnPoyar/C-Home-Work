// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string array = Console.ReadLine();
string[] words = array.Split(new Char[] { ' ' });
int size = array.Length;
if (size >= 3)
{
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}