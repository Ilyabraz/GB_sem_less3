﻿// Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

using System;
namespace Lesson3_task21
{ 
    class Program
{ 
    public static decimal sqrt(decimal x)
{ 
    decimal y = 1m, ynew; for (;;)
{ 
    ynew = (y + x / y) * 0.5m;
    
    if (ynew == y) return y; y = ynew; 
}
}
public static void Main()
{ 
    decimal [] x = new decimal [6];
    int i; decimal d, distance = 0m;
    Console.WriteLine("x1 y1 z1 x2 y2 z3:");
    var line = Console.ReadLine().Split();
    
    for (i = 0; i < 3; i++)
{ 
    d = Convert.ToDecimal(line[i + 3])
    - Convert.ToDecimal(line[i]);
    distance += d * d; 
}
Console.WriteLine(sqrt(distance)); 
}

}

}
