// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int number = 8; // задаем длинну массива
int[] array = new int[number];

FillArrayRandom(number); // Заполняем массив случайными числами
PrintArray(array); // выводим массив на экран

int[] FillArrayRandom(int length)
{
    Random random = new Random();

    for (int i = 0; i < number; i++)
    {
        int randomValue = random.Next(0, 100);
        array[i] = randomValue;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < number; i++)
    {
        if (i == 0)
        {
            Console.Write("[ ");
        }
        Console.Write($"{array[i]}");
        if (i < number - 1)
        {
            Console.Write(", ");
        }
        if (i == number - 1)
        {
            Console.Write(" ]");
        }
    }
}