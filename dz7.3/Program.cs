// Задача 52. Задайте двумерный массив из целых чисел размера NxN. 
// Укажите два числа,означающие строки, которые нужно поменять местами.

void Print(int[,] array)             // Метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)         // Метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void GetString(int[,] array, int s, int c)    // Метод замены выбранных строк
{
    if (s > array.GetLength(0) && c > array.GetLength(1) && s == 0 && c == 0) Console.Write($"Введите корректные данные");
    for (int j = 0, x = 0; j < array.GetLength(1); j++)
    {
        x = array[s - 1, j];
        array[s - 1, j] = array[c - 1, j];
        array[c - 1, j] = x;
    }
}

Console.Write($"Введите число строк и столбцов: ");
int row = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите число столбцов: ");
// int col = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите строку для замены 1: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите строку для замены 2: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, row];
FillArray(arr);
Print(arr);
Console.WriteLine();
GetString(arr, s, c);
Print(arr);

