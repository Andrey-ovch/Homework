// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void Print(double[,] array)     // Метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j],5:f2} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)   // Метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()*10-2;
        }
    }
}

Console.Write($"Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());


double[,] s = new double[row,col];
FillArray(s);
Print(s); 

