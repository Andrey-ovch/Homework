// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

int a = new Random().Next(10000, 100000);
// int a = 45654;
int x = a / 10000;
int y = a % 10000 / 1000;
int b = a % 100 / 10;
int c = a % 10;
// Console.WriteLine($"{x} {y} {b} {c}");
if (x == c & y == b)
{
    Console.WriteLine($"{a} -> да ");
}
else
{
    Console.WriteLine($"{a} -> нет");
}