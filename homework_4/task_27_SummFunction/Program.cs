// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number=452;
Console.WriteLine($"результат: {SummFunction(number)}");

number=82;
Console.WriteLine($"результат: {SummFunction(number)}");

number=9012;
Console.WriteLine($"результат: {SummFunction(number)}");

int SummFunction(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number%10);
        number = number / 10;
        // Console.WriteLine($" number - {number}");
        // Console.WriteLine($" summ - {sum}");
    }
    return sum;
}
