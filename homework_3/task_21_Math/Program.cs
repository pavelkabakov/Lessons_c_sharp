// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// Console.WriteLine(Math.Sqrt(4));

Console.WriteLine("Введите ax"); // Вводим координаты точки а
double ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ay");
double ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите az");
double az = double.Parse(Console.ReadLine());

Console.WriteLine("Введите bx"); // Вводим координаты точки б
double bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите by");
double by = double.Parse(Console.ReadLine());
Console.WriteLine("Введите zy");
double bz = double.Parse(Console.ReadLine());

double distance = GetDistance(ax, ay, az, bx, by, bz); 

Console.WriteLine($"расстояние между точками {Math.Round(distance, 2)}"); // вызываем, получаем значение, округляем до  двух знаков и выводим

double GetDistance(double ax, double ay, double az, double bx, double by, double bz) // описание метода
{
    return Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
}