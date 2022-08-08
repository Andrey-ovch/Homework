// Задача 25: Напишите метод, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Print(int result)
{
    Console.WriteLine($"Результат: {result}");
}

int Str(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}

Console.Write($"Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int Result = Str(a, b);
Print(Result);