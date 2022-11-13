// Найти сумму элементов от M до N, N и M заданы

int SumElements(int m, int n)
{
    if (m == n) return n;
    return m + SumElements(m + 1, n);
}
Console.WriteLine($"Сумма элементов = {SumElements(1, 10)} ");
