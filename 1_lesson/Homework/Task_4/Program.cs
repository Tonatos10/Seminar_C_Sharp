// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число, ");
int N = int.Parse(Console.ReadLine());

int x = 2;

while (x <= N)
{
    
    Console.Write($"{x}, ");
    x += 2;
}