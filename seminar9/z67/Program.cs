// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Задайте число: ");
int M = int.Parse(Console.ReadLine());

int SumNum(int num)
{
    if (num == 0) return 0;
    return SumNum(num/10) + num%10;
}

Console.WriteLine(SumNum(M));