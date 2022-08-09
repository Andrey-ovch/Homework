// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Print(int[] array)         // метод печати массива
{
   Console.Write($"Задан массив: ");
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void NewArray(int[] NewArray)           // метод заполнения массива
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = new Random().Next(100, 1000);
    }
}

int Count(int[] array)                   // метод нахождения количества четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] s = new int[15];
NewArray(s);
Print(s);
Console.WriteLine();
int Count2 = Count(s);
Console.Write($"Количество четных чисел: {Count2}");
