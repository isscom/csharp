// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Задайте значение N: ");
int N = int.Parse(Console.ReadLine());
void NumberSeries (int Num)
{
    if (Num==0) return;
    NumberSeries(Num-1);
    Console.WriteLine(Num);

}

NumberSeries(N);