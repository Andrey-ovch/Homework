﻿int a = new Random().Next(10, 150);
Console.WriteLine($"Дано случайное число {a}");
if (a < 100)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    int x = a % 10;
    Console.WriteLine($"Третья цифра: {x}");
}