// Напишите программу, которая принимает на вход трехзначное число и 
// на выходе показывает вторую цифру этого числа.

string TwoSecond(int num)

{
    if (num > 99 && num < 1000)
    {
        int result = ((num / 10) % 10);
        return $"{result} ";
    }
    else
        return "Введите трехзначное число";
}

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(TwoSecond(number)); 