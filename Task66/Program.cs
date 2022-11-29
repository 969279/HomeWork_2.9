/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int m = ReadInt("Задайте первое число: ");
int n = ReadInt("Задайте второе число: ");

if(m < n) 
{ 
    Console.WriteLine ($"Сумма чисел между {m} и {n}: {Sum(m, n)}");
} 
else 
{
    Console.WriteLine ($"Сумма чисел между {n} и {m}: {Sum(n, m)}");
}

int Sum(int i, int j)
{
    if (i != j)
    {
        return i + Sum(i + 1, j);
    } 
    return i;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
