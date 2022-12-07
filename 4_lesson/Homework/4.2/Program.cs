// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNums(int num)
{
    int sum = 0;
    int new_num = 0;

    while (num > 0)
    {
        new_num = num % 10;
        sum = sum + new_num;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(SumNums(n));