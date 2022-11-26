// Найти максимальное из 9 чисел
// Решение с массива и метода (функции).

int Max(int arg1, int arg2, int arg3) // Функция берет 3 числа и находит максимальное из них.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; // Метод (функция) возвращает результат.
}

//             0  1  2  3  4  5  6  7  8
int[] array = {12,22,23,24,52,62,72,48,95};

array[0] = 112; // Показано, как можно обратиться к массиву и записать в него значение.

// Console.WriteLine(array[4]); // оказано, как можно обратиться к массиву и
// получить из него значение соответствующего элемента по его индексу.

int result = Max(Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

    Console.WriteLine(result);