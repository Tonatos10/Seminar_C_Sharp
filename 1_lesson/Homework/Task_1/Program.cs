// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Большее число, ");
    Console.WriteLine($"{num1}");
    Console.Write("Меньшее число, ");
    Console.WriteLine($"{num2}");
}
else if (num1 < num2)
{
    Console.Write("Большее число, ");
    Console.WriteLine($"{num2}");
    Console.Write("Меньшее число, ");
    Console.WriteLine($"{num1}");
}
else if (num1 == num2)
{
    Console.WriteLine("Error");
}