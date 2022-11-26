void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10]; // Определяем новый массив и указываем,
// что в этом массиве будет 10 элементов. По умолчанию данный массив
// будет наполнен нулями (0).

FillArray(array); // Метод FillArray - заполнил нам массив.
PrintArray(array); // Метод PrintArray - распечатал значения.