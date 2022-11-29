// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

string Multiple(int num)
{
    if (num % 7 == 0 && num % 23 == 0) // && значит, что левое и правое выражения истины.
        return "кратно";
    else
        return "не кратно";
}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Multiple(number));