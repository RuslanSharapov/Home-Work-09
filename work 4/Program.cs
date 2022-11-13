/* 
Написать программу показывающие первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих.
Первые два элемента последовательности задаются пользователем 
*/


Console.Write("Введите количество высчитываемых чисел: ");
int N = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите первое число: ");
int FirstNum = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите второе число: ");
int SecondNum = int.Parse(Console.ReadLine()?? "0");


int Calculation(int a, int b, int num)
{
    if (num == 1) return a;
    if (num == 2) return b;
    return Calculation(a, b, num - 1) + Calculation(a, b, num - 2);
}
for (int i = 1; i <= N; i++)  // Если методом Фибоначи,то:    i < N
{
    Console.Write($"{Calculation(FirstNum, SecondNum, i)} ");
}


