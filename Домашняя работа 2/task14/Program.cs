// Задача 14: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number % 7;
int digit1 = number % 23;
if(digit == 0 & digit1 == 0)
{
    Console.WriteLine(" да ");
}
else
{
     Console.WriteLine(" нет ");
}