﻿// 3D

Console.WriteLine("Enter coordinates");

Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("c1: ");
int c1 = Convert.ToInt32(Console.ReadLine());


double ab = AB(a, b, a1, b1, c, c1);
Console.WriteLine(Math.Round(ab, 2, MidpointRounding.ToZero));

double AB(int x, int y, int x1, int y1, int z, int z1)
{
 double sqrt = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));
 return sqrt;
}

