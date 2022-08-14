// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


Console.Write($"Введите данные уравнения к1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите данные уравнения b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите данные уравнения к2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите данные уравнения b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

void Print(double[] array)                 // метод печати
{
    Console.Write($"Координаты точки пересечения: (  ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
    Console.Write($")");
}

double[] IntersecLine(double[] array)      // метод нахождения точки пересечения двух прямых
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) array[i] = (b2 - b1) / (k1 - k2);
        if (i == 1) array[i] = k1 * (b2 - b1) / (k1 - k2) + b1;
    }
    return array;
}


double[] z = new double[2];
IntersecLine(z);
Print(z);

