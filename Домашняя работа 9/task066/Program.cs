// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int numb = Convert.ToInt32(Console.ReadLine());


int SumRec(int m, int n)
{
    if(n<=m) return m;
    else return n + SumRec(m, n-1);
}

Console.WriteLine(SumRec(number, numb));

