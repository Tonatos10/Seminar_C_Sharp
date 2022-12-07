// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int NatDegree(int A, int B)
{
    int n = 1;
    
    for (int i = 1; i <= B; i++)
    {
        n = n * A;
    }
    return n;
}

Console.WriteLine("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(NatDegree(num1, num2));