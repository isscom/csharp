// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N2 = int.Parse(Console.ReadLine()); // Программа принимает на вход два числа
Console.Write($" {N1}, {N2} -> "); // Вывозим первую часть результата

if (N1 * N1 == N2 ^ N2 * N2 == N1)
    {
        Console.WriteLine("да");
    }
else
    {
        Console.WriteLine("нет");
    }