//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int GetAkkerman(int m, int n)
{

if (m == 0) 
{
    return n + 1;
}
else if (n == 0) 
{
    return GetAkkerman(m - 1, 1);
}
else {return GetAkkerman(m - 1, GetAkkerman(m, n - 1));}
}


int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = GetInput("Введите число 1:");
int n = GetInput("Введите число 2:");
Console.WriteLine($"M = {m}, N ={n} ->  A(m,n) = {GetAkkerman(m,n)}");

