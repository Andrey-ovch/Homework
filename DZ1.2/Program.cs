int a = new Random().Next(100, 1000);
Console.WriteLine($"Дано случайное число {a}");
int x = a % 100;
int z = x / 10;
Console.WriteLine($"Вторая цифра: {z}");