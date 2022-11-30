// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

string ThreeSecond(int num)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        return $"{num % 10} ";
    }
    else
        return "Третьей цифры нет";
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(ThreeSecond(num));