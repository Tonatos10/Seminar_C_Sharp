﻿// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find.
// Решение с помощью алгоритма.

//               0   1   2   3   4   5   6   7   8
int[] array = { 12, 22, 23, 24, 52, 95, 72, 48, 95 };

int n = array.Length; // Указываем сколько элементов находится с массиве.

int find = 95; // Искомый элемент?

int index = 0; // Точка отсчета

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // Прерви
    }
    index++;
}