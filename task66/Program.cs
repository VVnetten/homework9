// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int start, int end)
{
    int sum = 0;
    if (end > start)
    {
        sum = sum+start;
        start++;
        return sum  + GetSum(start, end);
    }
    sum = sum+end;
    return sum;
}
int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = GetInput("Введите число 1:");
int n = GetInput("Введите число 2:");
Console.WriteLine($"M = {m}, N ={n}  ");
Console.WriteLine(GetSum(m,n));