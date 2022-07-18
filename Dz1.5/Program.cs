int a = new Random().Next(-1, 12);
Console.WriteLine($"День недели: {a}");

if (a < 1 | a > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
    int index = 0;
    if (a == array[index++]) Console.WriteLine("Это понедельник");
    if (a == array[index++]) Console.WriteLine("Это вторник");
    if (a == array[index++]) Console.WriteLine("Это среда");
    if (a == array[index++]) Console.WriteLine("Это четверг");
    if (a == array[index++]) Console.WriteLine("Это пятница");
    if (a == array[index++]) Console.WriteLine("Это суббота");
    if (a == array[index++]) Console.WriteLine("Это воскресенье");
}

