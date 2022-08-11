// Написать программу, которая будет принимать
//на вход 2 числа и выводит, является ли второе число
//кратным первому числу. Если 2е число не кратно первому
//числу, то прог-ма выводит остаток от деления.
//34, 5 - не кратно, остаток 4, 16, 4 - кратно.
Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());
int res = (num1 % num2);

if (res == 0) //деление % - остаток
{
    Console.Write("is a multiple");
} else {
    Console.Write($" is not a multiple, the remainder: {res}");
}