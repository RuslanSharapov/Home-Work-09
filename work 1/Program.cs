// Показать натуральные числа от M до N, N и M заданы

void PrintNumbers(int m, int n)
{
    if (m > n) return;
    PrintNumbers(m, n - 1);
    Console.Write($"{n} ");
}
PrintNumbers(1, 10);
