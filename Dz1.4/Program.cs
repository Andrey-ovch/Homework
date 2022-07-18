int a = new Random().Next(-1, 12);
Console.WriteLine($"День недели: {a}");

 if(a < 1 | a > 7)
{
    Console.WriteLine($"Такого дня недели нет");  
}
 else
{
    if (a == 6 | a == 7)
    {
        Console.WriteLine("Да является выходным");
    }
    else
    {
        Console.WriteLine("Нет не является выходным");
    }   
}

    