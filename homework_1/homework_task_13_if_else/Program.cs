// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int numberA = int.Parse(Console.ReadLine()); 
Console.WriteLine($"Вы ввели число - {numberA}");

int i=1;

if ( numberA > 9 & numberA < 100 ) // фильтруем двузначные
{
    Console.WriteLine($"Число {numberA} двузначное третьей цифры нет");
}
else if ( numberA > 0 & numberA < 9 ) // фильтруем однозначные
{
    Console.WriteLine($"Число {numberA} однозначное, третьей цифры нет");
}
else if ( numberA > 99) // Фильтруем все что больше трехзначного, делим на 10 до трех знаков
{
      int result=numberA;
        while (result > 1000) // 
    {
        result = numberA / i;
        i=i*10;
    
    }
    Console.WriteLine($"третьей цифрой числа {numberA} является - {result % 10}"); //  получаем и выводим третий разряд
}