/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Clear();
Console.WriteLine("Первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Число : ");
    Console.Write(number1);
    Console.Write(" больше чем число: ");
    Console.Write(number2);
}
else if (number1 < number2)
{
    Console.Write("Число : ");
    Console.Write(number2);
    Console.Write(" больше чем число: ");
    Console.Write(number1);
}
else if (number1 == number2)
{
    Console.Write("Числа равны");
}