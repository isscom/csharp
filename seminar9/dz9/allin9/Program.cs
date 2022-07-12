//---------------------------------------------------------------------------------------------------------
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//---------------------------------------------------------------------------------------------------------
Console.Write("Введите целочисленное значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите целочисленное значение N: ");
int N = int.Parse(Console.ReadLine());

void NumberSeries(int numberStart, int numberFinish, int direction)
{
    if (numberStart == numberFinish+direction)
    {
        return;
    }
    Console.WriteLine(numberStart);    
    NumberSeries(numberStart+direction, numberFinish, direction);
    return;
}

int growDirection;
if (M<N)
{
    growDirection = 1;
}
else
{
    growDirection = -1;
}
NumberSeries(M, N, growDirection);

//---------------------------------------------------------------------------------------------------------------
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//---------------------------------------------------------------------------------------------------------------
Console.Write("Введите целочисленное значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите целочисленное значение N: ");
int N = int.Parse(Console.ReadLine());

(int numberStart, int numberFinish) MinMax(int numberStart, int numberFinish)
{
    int tmp;
    if (numberStart > numberFinish)
    {
        tmp = numberStart;
        numberStart = numberFinish;
        numberFinish = tmp;
    }
    return (numberStart, numberFinish);
}

int SumAB(int numberStart, int numberFinish)
{
    int sumAB=0;
    if (numberStart > numberFinish)
    {
        return 0;
    }
    Console.WriteLine(numberStart);
    return sumAB=SumAB(numberStart+1, numberFinish)+numberStart;
}

(N, M) = MinMax(N, M);
Console.Write(SumAB(N, M));

//---------------------------------------------------------------------------------------------------------
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//---------------------------------------------------------------------------------------------------------
int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return -100500;
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

if (Akkerman(m, n) == -100500)
{
    Console.WriteLine($"Функция Аккермана определена только для неотрицательных целых чисел. Зайдайте допустимые значения m и n.");
}
else
{
    Console.WriteLine($"Функция Аккермана для m={m} и n={n} равна {Akkerman(m, n)}");
} 