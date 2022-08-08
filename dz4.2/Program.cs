// Задача 27: Напишите метод, который принимает на вход
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Print(int sum)
{
    Console.Write($"Сумма цифр в числе: {sum}");
}

Console.Write($"Введите число: ");
int s = Convert.ToInt32(Console.ReadLine());

int Summa(int s)
{
    int length = Convert.ToString(s).Length;
    int c = 0;
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        c = s % 10;
        sum = sum + c;
        s = s / 10;
    }
    return sum;
}

int d = Summa(s);
Print(d);