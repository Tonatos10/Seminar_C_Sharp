// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число, ");
int num = int.Parse(Console.ReadLine());

int x = num % 2; // % - деление без остатка

if (x == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}