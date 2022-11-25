// 0. Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя).

Console.WriteLine("Write a number: "); // Вывод сообщения

int num = int.Parse(Console.ReadLine()); // Указываем, что num это целое число (int num) 
//и преобразовываем строку в число int.Parse(Console.ReadLine())

Console.WriteLine(num * num); 