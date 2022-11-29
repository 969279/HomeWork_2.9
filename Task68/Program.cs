/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");

Console.WriteLine($"Функция Аккермана A({m},{n}) = {AkkermanFunction(m, n)}");

int AkkermanFunction (int i, int j)
{
    if (i == 0) 
    {
        return j + 1;
    }   
        if (i != 0 && j == 0)
        {
            return AkkermanFunction(i - 1, 1);
        }
            if (i > 0 && j > 0)
            {
                return AkkermanFunction(i - 1, AkkermanFunction(i, j - 1));                
            } 
            else return AkkermanFunction(i, j);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
