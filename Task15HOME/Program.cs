//Задача 15: Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным. 6 -> да, 7 -> да, 1 -> нет
Console.Clear();
Console.Write("Enter int number: ");
int a = Convert.ToInt32(System.Console.ReadLine());
if( a == 1) System.Console.WriteLine("No");
else if( a == 2) System.Console.WriteLine("No");
else if( a == 3) System.Console.WriteLine("No");
else if( a == 4) System.Console.WriteLine("No");
else if( a == 5) System.Console.WriteLine("No");
else if( a == 6) System.Console.WriteLine("Yes");
else if( a == 7) System.Console.WriteLine("Yes");
else System.Console.WriteLine("Number is not diapasone");