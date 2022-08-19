// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

// задача посложнее - вводить позицию в одну строку. символ-разделитель - запятая

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

void Element(int[,] array, int s, int c)   //Метод нахлждения нужного элемента по заданной позиции
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array.GetLength(0) == 0 && array.GetLength(1) == 0) break;
            if (s == 0 && c == 0) break;
        }
    }
    if (s < array.GetLength(0) && c < array.GetLength(1)) Console.Write($"Значение элемента массива: {array[s - 1, c - 1]}");
    else Console.Write("Такого числа нет");
}

Console.Write($"Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите координаты строки: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координаты столбца: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[row, col];
FillArray(Array);
Print(Array);
Console.WriteLine();
Element(Array, s, c);
