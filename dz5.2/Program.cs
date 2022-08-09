// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Print(int[] array)                     // печать массива
{
    Console.Write($"Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void NewArray(int[] array, int a, int b)                  // создание и заполнение массива случайными числами с диапазона (a,b)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a, b);
    }
}

int Sum(int[]array)                         // нахождение суммы элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] s = new int[10];
NewArray(s, -5, 10);
Print(s);
Console.WriteLine();
int Summa = Sum(s);
Console.Write($"Сумма равна: {Summa}");

