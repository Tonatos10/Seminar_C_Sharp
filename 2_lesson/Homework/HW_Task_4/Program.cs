// Напишите программу, которая принимает на вход цифру, обазначающую
// день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (num < 1 || num > 7)
    Console.WriteLine("С таким номером дня недели не существует");
else if (num > 5)
{
    Console.WriteLine("Выходной!");
}
else Console.WriteLine("Будни");