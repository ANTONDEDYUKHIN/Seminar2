//Написать программу, которая
// на вход принимает 2 числа и
// является ли оно квадратом другого
Console.Write("Enter number1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b || b *b == a)
{
    Console.WriteLine("One number is the square of another number.");
} else
{
    Console.WriteLine("Neither number is the square of the other.");
}