// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X !=0 или Y !=0 и выдает номер четверти плоскости, в которой
// находится эта точка.

void Quarter(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}
Quarter(10, 9);