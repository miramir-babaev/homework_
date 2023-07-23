/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите первое число => ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число => ");
int n = Convert.ToInt32(Console.ReadLine());

Num(m, n);

void Num(int m, int n)
{
    Console.WriteLine(SumNum(m - 1, n));
}

int SumNum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumNum(m, n);
        return res;
    }
}