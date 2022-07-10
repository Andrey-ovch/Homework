int a = new Random().Next(-10, 10);
int b = new Random().Next(-15, 35);
int max = a;
int min = b;

if (a > max)
{
    max = a;
    Console.WriteLine(a + " > " + b);
    Console.Write("max = ");
    Console.WriteLine(max);
}
else
{
    max = b;
    Console.WriteLine(b + " > " + a);
    Console.Write("max = ");
    Console.WriteLine(max);
}    

if (a < min)
{
    min = a;
    Console.WriteLine(a + " < " + b);
    Console.Write("min = ");
    Console.WriteLine(min);
}
else
{
    min = b;
    Console.WriteLine(b + " < " + a);
    Console.Write("min = ");
    Console.WriteLine(min);
}    