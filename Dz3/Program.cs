// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
int a = new Random().Next(-10, 10);
Console.WriteLine(a);

if(a % 2 == 0)
{
    Console.Write("Число четное");    
}
else
{
    Console.Write("Число не четное");    
}