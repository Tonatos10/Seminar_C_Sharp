// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

int Summ(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Summ(m, n);
        return res;
    }
}

Console.Write("Введите число1: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число2: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {Summ(m-1, n)} ");