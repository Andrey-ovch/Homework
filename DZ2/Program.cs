﻿int a = new Random().Next(-10, 15);
int b = new Random().Next(-3, 25);
int c = new Random().Next(1, 5);
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);