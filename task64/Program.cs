// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int Natural(int start, int end)
{
    if (end < start)
    {
        Console.Write(start);
        start--;
        return Natural(start, end);
    }
    return end;
}


int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int num = GetInput("Введите число:");
Console.WriteLine(Natural(num,1));