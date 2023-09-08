﻿// Задача No21. Работа в группах
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

//AB = √(xb - xa)2 + (yb - ya)2

// Console.WriteLine(Math.Sqrt(4));

Console.WriteLine("Введите ax");
double ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ay");
double ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите bx");
double bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите by");
double by = double.Parse(Console.ReadLine());

double distance = GetDistance(ax, ay, bx, by);

Console.WriteLine($"расстояние между точками {distance}");

double GetDistance (double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2));
}