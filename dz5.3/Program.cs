// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(double[] array)                 // печать массива
{
    Console.Write($"Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
}

void Array(double[] array)   // заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*10-2;
    }
}

double Dif(double[] array)                    // нахождение разницы между максимальным и минимальным значением
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

double[] s = new double[10];
Array(s);
Print(s);
Console.WriteLine();
double c = Dif(s);
Console.Write($"Разница между max и min равна: {c:f2}");