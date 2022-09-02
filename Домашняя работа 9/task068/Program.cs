// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите неотрицательное число m");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n");
double numb = Convert.ToDouble(Console.ReadLine());
if (number >= 0 && numb >= 0)
{
    Console.Write(AkkermansFunction(number, numb));
}

double AkkermansFunction(double m, double n)
{
    if(m==0) return n+1;
    if( n==0) return AkkermansFunction(m-1, 1);
    else return AkkermansFunction( m-1, AkkermansFunction(m, n-1));
}


