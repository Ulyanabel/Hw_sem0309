// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int n = Convert.ToInt32(Console.ReadLine());
num = Convert.ToInt32(Console.ReadLine());
num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}");
