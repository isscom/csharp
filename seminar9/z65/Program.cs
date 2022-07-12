// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Задайте значение M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Задайте значение N: ");
int N = int.Parse(Console.ReadLine());

(int NumberStart, int NumberFinish) MinMax (int NumberStart, int NumberFinish)
{
    int tmp;
    if (NumberStart > NumberFinish)
    {
        tmp = NumberStart;
        NumberStart = NumberFinish;
        NumberFinish = tmp;
    }
    return (NumberStart, NumberFinish);
}

void NumSer (int NumberStart, int NumberFinish)
{
    if (NumberStart > NumberFinish) return;
    Console.WriteLine(NumberStart);
    NumSer(NumberStart+1, NumberFinish);
}

(N, M) = MinMax(N,M);
NumSer(N,M);