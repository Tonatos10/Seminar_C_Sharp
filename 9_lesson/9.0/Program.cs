﻿// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void Chisla(int a)
{
    if(a == 0) return;
    Chisla(a-1);
    Console.Write($" {a} ");
}
Chisla(5);