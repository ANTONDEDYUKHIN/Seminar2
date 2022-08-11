//Написать программу, которая принимает
//на вход число и проверяет кратно ли оно
//одновременно 7 и 23. 14->нет, 46->нет, 161->да
Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    Console.Write($"Number {a} is a multiple of 7 and 23 at the same time");
} else
{
    Console.Write($"Number {a} is not a multiple of 7 and 23 at the same time");
}