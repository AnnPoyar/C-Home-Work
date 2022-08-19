int[] Array = new int[8];
Console.WriteLine("Введите восемь целых чисел для создания массива:");
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введенный массив:");
Console.Write(string.Join(",", Array));