// Написать программу вычисления функции Аккермана

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()?? "0");

int AckermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AckermanFunc(m - 1, 1);
    else
        return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}
Console.WriteLine($"A({m}, {n}) = {AckermanFunc(m, n)}");
