// Написать программу, которая выводит случайное
// число из отрезка [10, 99] и показывает
// наибольшую цифру числа. 78 - 8, 12 - 2, 85 - 8.
// Реализована через метод.
Console.Clear();
int number = new Random().Next(10, 100);//10, 99+1
Console.WriteLine($"Случайное число из диапазона 10- 99 =>{number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int result = MaxDigit(number);
string res = result == 0 ? "Цифры равны." : result.ToString();
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");