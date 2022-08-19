// Реализовать программу поворота матрицы

void Print(int[,] array)                         // метод печати массива
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

void FillArray(int[,] array)                    // метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void TurnArray90(int[,] array)                  // метод поворота массива на 90*
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    int s = array.GetLength(0);
    int b = array.GetLength(1);
    for (int i = 0; i < s; i++)
    {
        for (int j = 0, c = s - 1; j < b; j++, --c)
        {
            newArray[i, j] = array[c, i];
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void TurnArray180(int[,] array)                 // метод поворота массива на 180*
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    int s = array.GetLength(0);
    int b = array.GetLength(1);
    for (int i = 0, c = s - 1; i < s; i++, --c)
    {
        for (int j = 0, x = b - 1; j < b; j++, --x)
        {
            newArray[i, j] = array[c, x];
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void TurnArray270(int[,] array)                 // метод поаорота массива на 270*
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    int s = array.GetLength(0);
    int b = array.GetLength(1);
    for (int i = 0, c = s - 1; i < s; i++, --c)
    {
        for (int j = 0; j < b; j++)
        {
            newArray[i, j] = array[j, c];
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Array = new int[4, 4];
FillArray(Array);
Print(Array);
Console.WriteLine();
TurnArray90(Array);
Console.WriteLine();
TurnArray180(Array);
Console.WriteLine();
TurnArray270(Array);




