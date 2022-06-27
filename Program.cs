// Задача 1. // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());

int firstDigit = a / 10;
int secondDigit = firstDigit % 10; 
Console.WriteLine($"{a} -> {secondDigit}" );

