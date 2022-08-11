// Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что 
//третьей цифры нет. Решить без использования строк.
//645 -> 5,  78 -> третьей цифры нет,  32679 -> 6
Console.Clear();
int a = new Random().Next(0, 100000);
//Console.Write("Ведите Число ");
//int a = Convert.ToInt32(System.Console.Read());
Console.WriteLine($"Число = {a}");

if (a < 100)
{
Console.WriteLine("Нет третьей цифры.");
} else
   if (a < 1000)
{
        int num1 = a % 10;
        Console.Write($"-> {num1}");//Console.WriteLine($"Вывод третьей цифры: {a} -> {num1}");
} else
   if (a < 10000)
{
        int num2 = ((a % 100) / 10);
        Console.Write($"-> {num2}");//Console.WriteLine($"Вывод третьей цифры: {a} -> {num2}");
} else
    if (a < 100000)
{
        int num3 = ((a % 1000) / 100);
        Console.WriteLine($"-> {num3}");//Console.WriteLine($"Вывод третьей цифры: {a} -> {num3}");
}