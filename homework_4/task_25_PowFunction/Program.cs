// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int number=3; int pow=5;
Console.WriteLine($"результат: {PowFunction(number, pow)}");

number=2; pow=4;
Console.WriteLine($"результат: {PowFunction(number, pow)}");


int PowFunction(int number, int pow)
{
    int result=number;
    for (int i = 1; i < pow; i++)
    {
        result = result * number;
    }
    return result;
}

// результат: 243
// результат: 16