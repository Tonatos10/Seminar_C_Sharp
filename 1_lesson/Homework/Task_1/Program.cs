// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter the first number ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("The largest number ");
    Console.WriteLine($"{num1}");
}
else if (num1 < num2)
{
    Console.Write("The largest number ");
    Console.WriteLine($"{num2}");
}
else if (num1 == num2)
{
    Console.WriteLine("Error");
}