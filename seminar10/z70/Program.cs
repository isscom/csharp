// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 

int SumPreviosTwo (int numFirst, int numSecond, int num)
    {
        if (num == 1) return numFirst;
        if (num == 2) return numSecond;
        return SumPreviosTwo(numFirst, numSecond, num-1) + SumPreviosTwo(numFirst, numSecond, num-2);
    }

Console.Clear();

Console.WriteLine("Введите первое число: ");
int numberFirst = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberSecond = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= N; i++)
{
    Console.Write($"{SumPreviosTwo(numberFirst, numberSecond, i)} ");
}

