// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("Enter the number 1 "); // Вывод сообщения
int num2 = int.Parse(Console.ReadLine()); // Присваивание значения

Console.WriteLine("Enter the number 2 "); // Вывод сообщения
int num1 = int.Parse(Console.ReadLine()); // Присваивание значения

if(num2 == num1 * num1)
{
    Console.WriteLine("Yes"); // Если условие выполняется, то Yes
}

else
    Console.WriteLine("No"); // Если условие не выполняется, то No