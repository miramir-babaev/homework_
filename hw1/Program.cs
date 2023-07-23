/* Задача 1: Задайте значение N. Напишите программу, которая выведет все ЧЕТНЫЕ натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
N = 5, M = 9-> "6, 8"
N = 2, M = 10-> "2, 4, 6, 8, 10" */

Console.Write("Введите первое число => ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число => ");
int n = Convert.ToInt32(Console.ReadLine());
void EvenNum(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{m},");
    }
    EvenNum(m + 1, n);
}
EvenNum(m, n);