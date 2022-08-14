// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string array = Console.ReadLine();
string[] words = array.Split();
int size = array.Length;
if (size == 5)
{
    if(array[0]==array[4] & array[1]==array[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("неверно введено число");
}
