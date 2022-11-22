// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
var num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {num} = {SumOfNumbers(module(num))}");

int SumOfNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int module(int num)
{
    return num>0 ? num : -num;
}