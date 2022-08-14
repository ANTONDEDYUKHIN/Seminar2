//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого
// числа. Решить без использования строк. 456 -> 5
//782 -> 8,  918 -> 1
Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число: {number}");
int num1 = number / 10;
Console.WriteLine($"Число 1: {num1}");
int num2 = number / 100;
Console.WriteLine($"Число 2: {num2}");
int num3 = num1 - num2*10;
Console.WriteLine($"Вторая цифра трехзначного числа: {number} -> {num3}");