// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int lenght = AskIntNumber("Введите длину массива: ");
if (lenght > 0)
{
    int[] array = AskIntArray(lenght);
    PrintArray(array);
}
else
    Console.WriteLine("Неверная длина массива");


int[] AskIntArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
        array[i] = AskIntNumber($"Введите {i + 1} число:");
    return array;
}

int AskIntNumber(string WelcomeText)
{
    Console.Write(WelcomeText);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
        Console.Write(array[i] + ((i == count - 1) ? "]" : ", "));

}