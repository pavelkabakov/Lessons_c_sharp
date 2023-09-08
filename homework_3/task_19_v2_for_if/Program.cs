// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// вариант если не использовать работу со строками

Console.WriteLine("Введите число, для проверки на паллиндром");
string str = Console.ReadLine();
int length = str.Length;
if (detectPalindrom(str))
{
    Console.WriteLine($"Число {str} является паллиндромом");
}
else
{
    Console.WriteLine($"Число {str} не является паллиндромом");
}

bool detectPalindrom(string str)
{
    bool palindrom = false;
    for (int i = 0; i < (str.Length - 1) / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            palindrom = false;
            break;
        }
        palindrom = true;
    }
    return palindrom;
}





