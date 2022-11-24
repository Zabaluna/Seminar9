// Задача 64: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
// M = 5; N = 1. -> "5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(m,n);

void PrintNumbers(int m, int n)
{
    Console.Write($"{m}, ");
    if (m == n) return;
    PrintNumbers(m - 1, n);
}

