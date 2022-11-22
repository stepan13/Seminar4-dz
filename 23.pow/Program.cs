// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

var A = AskIntNumber("Введите число которое возводить в степень: ");
var B = AskIntNumber("Введите показатель степени: ");
if (B < 0)
    Console.WriteLine("Не умею считать корни");
else
{
    var result = Pow(A, B);
    Console.WriteLine($"{A}^{B}={result}");
}

int AskIntNumber(string WelcomeText)
{
    Console.Write(WelcomeText);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int num, int index)
{
    int result = 1;
    for (int i = 0; i < index; i++)
        result *= num;

    return result;
}