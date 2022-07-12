// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Write("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine());

void NumberSeries(int numberStart, int numberFinish, int counter)
{
    if (numberStart == numberFinish+counter)
    {
        return;
    }
    Console.WriteLine(numberStart);    
    NumberSeries(numberStart+counter, numberFinish, counter);
    return;
}

int count;
if (M<N)
{
    count = 1;
}
else
{
    count = -1;
}
NumberSeries(M, N, count);