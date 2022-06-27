// Задача 1. // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());

int firstDigit = a / 10;
int secondDigit = firstDigit % 10; 
Console.WriteLine($"{a} -> {secondDigit}" );

//Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if (b.Length > 2)
{
  Console.WriteLine("третья цифра -> " + b[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}


// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число (1-7) ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7)  
{
   Console.WriteLine("Выходной");
}

else
{
Console.WriteLine("Будни");
}
