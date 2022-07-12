// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

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