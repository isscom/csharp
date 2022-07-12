// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) // в примере ошибка (исправлен ответ)

Console.WriteLine("Введите координату b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату k2: ");
double k2 = double.Parse(Console.ReadLine());

double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round(((k1 * b2) - (k2 * b1)) / (k1 - k2), 2);

if (((k1 * x) + b1) == ((k2 * x) + b2))
    {
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y}).");
    }
else
{
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> Линии не пересекаются");
}
