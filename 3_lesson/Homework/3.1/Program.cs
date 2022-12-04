// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    return result;
}

Console.WriteLine("Введите aX:");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите aY:");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите aZ:");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите bX:");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите bY:");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Введите bZ:");
int bz = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Round(Distance(ax, ay, az, bx, by, bz), 2));