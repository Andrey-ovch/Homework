// Написать программу перемножения матриц 
// Программа сложения матриц

void Print(int[,] array)       // печать массива 
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

void NewArray(int[,] array)    // заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SumArray(int[,] array, int[,] array1)       // метод сложения матриц 
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = array[i, j] + array1[i, j];
            Console.Write($"{sum,2} ");
        }
        Console.WriteLine();
    }
}

void MultArray(int[,] array, int[,] array1)      // метод перемножения матриц
{
    int[,] result = new int[array.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                result[i, j] += array[i, k] * array1[k, j];
            }
            Console.Write($"{result[i, j],3} ");
        }
        Console.WriteLine(); 
    }
}

Console.Write($"Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] s = new int[row, col];
NewArray(s);
int[,] c = new int[row, col];
NewArray(c);

Print(s);
Console.WriteLine();
Print(c);
Console.WriteLine();
SumArray(s, c);
Console.WriteLine();
MultArray(s, c);

