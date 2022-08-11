//Написать программу, которая выводит случайное
//трехзначное число и удаляет вторую цифру
//этого числаю 456 - 46, 782 - 72, 918 -98
int number = new Random().Next(100, 1000);
int num1 = number / 100; //9
int num2 = number % 10; //8
int num3 = num1 * 10 + num2;
Console.WriteLine($"Вывод трехзначного числа: {number}");
Console.WriteLine($": {num3}");