/*
QuickSort(Быстрая Сортировка)
O(n * log2(n))
*/
// [5, 8, 23, 4, 2, 1, 10]
// [5, 8, 23, 10]
// [4, 2, 1]

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Метод флажка <-> return
recSsort(array, 0, array.Length - 1, 0);

Console.WriteLine($"Отсортированный массив: [{string.Join(", ", array)}]");

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-100; 100]
}

int SortQuick(int[] array, int start, int end)
{
    int temp;
    int marker = start;
    for (int i = start; i < end; i++)
    {
        if (array[i] < array[end])
        {
            temp = array[marker];
            array[marker] = array[i];
            array[i] = temp;
            marker += 1;
        }
    }
    temp = array[marker];
    array[marker] = array[end];
    array[end] = temp;
    return marker;
}

void recSsort(int[] array, int start, int end, int count)
{
    count++;
    Console.WriteLine($"[{string.Join(", ", array)}]");
    Console.WriteLine($"Количество {count} нач. {start} кон. {end}");
    if (start >= end)
        return ;
    int pivot = SortQuick(array, start, end);
    recSsort(array, start, pivot - 1, count);
    recSsort(array, pivot + 1, end, count);   
}




// Метод флажка
// int i = 1;
// bool flag = true;
// while (i < 2019 && flag)
// {
//     if (i % 573 == 0)
//     {
//         Console.WriteLine(i);
//         flag = false;
//     }
//     i++;
// }
// bool flag = true;
// int j = 5;
// for (int i = 1; i < 5 && flag; i++)
// {
//     if (i == 3)
//         flag = false;

//     j = i;
// }
// Console.WriteLine(j);