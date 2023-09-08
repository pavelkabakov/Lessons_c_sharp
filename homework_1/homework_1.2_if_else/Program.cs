/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear(); // очистка экрана перед выводом
Console.WriteLine("Введите количество элементов массива: ");
int numbers = int.Parse(Console.ReadLine()); // число элементов массива
Console.Clear(); // очистка экрана перед выводом
int[] arrayNumbers = new int[numbers]; //массив
int i = 0; // счетчик
int maxNumber = 0; // максимальное число
int minNumber = 0; // минимальное число
while (i < numbers)
{
    Console.Write("Введите число номер "); // Вводим числа
    Console.Write(i + 1);
    Console.Write(" : ");
    arrayNumbers[i] = int.Parse(Console.ReadLine());
    Console.WriteLine(arrayNumbers[i]);

    if (i == 0) //Присваиваем первоначальные значения
    {
        maxNumber = arrayNumbers[i]; 
        minNumber = arrayNumbers[i]; 
    }
    if (maxNumber < arrayNumbers[i]) // Находим максимум и минимум
    {
        maxNumber = arrayNumbers[i];
    }
    else if (minNumber > arrayNumbers[i])
        {
        minNumber = arrayNumbers[i];
    }
    i = i + 1; // увеличиваем счетчик
}
Console.Write("Максимальное из введенных чисел = ");
Console.WriteLine(maxNumber);
Console.Write("Минимальное из введенных чисел = ");
Console.WriteLine(minNumber);

/*
можно конечно и без массива перебирать при вводе
*/