﻿//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого
// числа. Решить без использования строк. 456 -> 5
//782 -> 8,  918 -> 1
Console.Clear();
int number = new Random().Next(100, 1000);//Выбирает случайное 3значное число
Console.WriteLine($"Трехзначное число: {number}");//Выводит случайное 3значное число на экран в консоли
int num1 = number / 10;// вычисляет ЦЕЛОЕ 2хзначное число 918/10=91
Console.WriteLine($"Число 1: {num1}");//Выводит ЦЕЛОЕ 2хзначное число "NUM1" на экран в консоли
int num2 = number / 100;// вычисляет ЦЕЛОЕ 1означное число 918/100=9
Console.WriteLine($"Число 2: {num2}");//Выводит ЦЕЛОЕ 1означное число "NUM2" на экран в консоли
int num3 = num1 - num2*10;// производит матем вычисление, чтобы получить 2ю цифру числа: 91 - 9*10 = 1.
Console.WriteLine($"Вторая цифра трехзначного числа: {number} -> {num3}");//выдает ответ в косоли на экран 1.