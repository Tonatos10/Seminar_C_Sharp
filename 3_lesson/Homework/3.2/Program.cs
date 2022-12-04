// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Kub(int N)
{
    int i = 0;
    double result;
    while (i < N)
    {
        i += 1;
        if (i == (N))
        {
            result = Math.Pow(i, 3);
            Console.Write($"{result}");
        }
        else
        {

            result = Math.Pow(i, 3);
            Console.Write($"{result},");
        }
    }
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Kub(num);