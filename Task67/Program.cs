﻿// Задача 67: Напишите программу, которая будет принимать на вход 
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());


SumDigit(n);

int SumDigit(int n)
{
    if (n == 0) return 0;
    return n%10 + SumDigit(n/10);
}
Console.Write(SumDigit(n));