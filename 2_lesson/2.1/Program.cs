// Напишите программу, которая выводит случайное трехзначное
// число и на выходе показывает последнюю цмфру этого числа.

int NewNumber(int num)
{
    return num % 10;
}
Console.WriteLine(NewNumber(new Random().Next(100, 1000)));