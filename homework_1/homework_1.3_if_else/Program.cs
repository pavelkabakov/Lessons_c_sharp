﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear(); // очистка экрана перед выводом
Console.WriteLine("Введите число: ");
int numbers = int.Parse(Console.ReadLine()); // Вводим число
if ( (numbers % 2) == 0) //проверяем на четность, Оператор остатка % вычисляет остаток от деления левого операнда на правый.
{
Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}