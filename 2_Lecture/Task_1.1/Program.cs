// Найти максимальное из 9 чисел
// Решение с помощью метода (функции)

int Max(int arg1, int arg2, int arg3) // Функция берет 3 числа и находит максимальное из них.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; // Метод (функция) возвращает результат.
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 333;

int max1 = Max(a1, b1, c1); // Результатом работы фунции Max
// будет являться максимальное из 3х чисел
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

// Можно переписать результирующий вариант таким способом
//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);