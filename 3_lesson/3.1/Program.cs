// Напишите программу, которая по заданному номеру четверти,
// показывает дмапазон возможных координат точек в этой четверти (x и Y).

void Quarter(string num)
{
    if (num == "I")
        Console.WriteLine("x > 0 && y > 0");
    else if (num == "II")
        Console.WriteLine("x < 0 && y > 0");
    else if (num == "III")
        Console.WriteLine("x < 0 && y < 0");
    else if (num == "IV")
        Console.WriteLine("x > 0 && y < 0");
    else
        Console.WriteLine("error");
}
Console.Write("Введите номер четверти: ");
Quarter(Console.ReadLine());