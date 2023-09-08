// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine()); 
Console.WriteLine($"Вы ввели число - {numberA}");

int digit1 = (numberA /10) % 10;
Console.WriteLine($"Второй разряд это - {digit1}");