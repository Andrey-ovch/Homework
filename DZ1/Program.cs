// Нахождение и вывод max и min значения
int a = new Random().Next(-10, 10);
int b = new Random().Next(-15, 35);
int max = a;
int min = b;

if (b > max) max = b;
if (a < min) min = a;

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);