// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Вариант если изучить документацию и использовать работу со строками
// создал вторую строку, отзеркалил строку и сравнил

Console.WriteLine("Введите число, для проверки на паллиндром");
string str = Console.ReadLine();  

System.Text.StringBuilder sb = new System.Text.StringBuilder(str);

for (int i = 0; i < str.Length; i++)
{
    sb[i] = (str[str.Length - i - 1]);
}
string strBack = sb.ToString();
Console.WriteLine(strBack);

if (str == strBack)
{
    Console.WriteLine($"Число {str} является паллиндромом");
}
else
{
    Console.WriteLine($"Число {str} не является паллиндромом");
}

