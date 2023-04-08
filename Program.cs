/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());

int[] array = GetArray(len);
PrintArray(array);


int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1}й элемент: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
}