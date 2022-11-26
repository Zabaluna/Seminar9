﻿// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число n : ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m : ");
int m = int.Parse(Console.ReadLine());
Ackermann(m, n);

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m, n);
}

Console.WriteLine($"{Ackermann(m, n)}");

