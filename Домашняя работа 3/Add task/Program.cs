// Доп. задача
//Написать программу для разворота массива

void FillArray(int[] numbers)
{
    int Length = numbers.Length;
    int index = 0;
    while (index < Length)
    {
        numbers[index] = new Random().Next(1, 9);
        index++;
    }

}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Sort(int[] array)
{
    for (int i = 0; i < (array.Length / 2); i++)
    {
        int temporary = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temporary;
    }
}

int[] array = new int[9];
FillArray(array);
PrintArray(array);
Sort(array);
PrintArray(array);
