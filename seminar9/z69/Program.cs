// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Задайте число А: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Задайте число В: ");
int B = int.Parse(Console.ReadLine());

int PowAB (int num, int pow)
{
    if (pow == 0) return 1;
    return PowAB(num, pow-1) * num;
}

Console.WriteLine(PowAB(A, B));
