﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Clear(); // очистка экрана перед выводом
Console.WriteLine("Введите число: ");
int numbers = int.Parse(Console.ReadLine()); // Вводим число
int i = 0; //Добавляем счетчик
Console.WriteLine("Список всех четных чисел");
while (i <= numbers)
{
    if ((( i % 2) == 0) & (i != 0) ) //проверяем на четность, Оператор остатка % вычисляет остаток от деления левого операнда на правый.
    {
        Console.Write(i);
        Console.Write(" , ");
    }
    i=i+1;
}