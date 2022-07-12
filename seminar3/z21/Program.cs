//Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату первой точки: ");
Console.Write("X1 = ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Y1 = ");
double Y1 = double.Parse(Console.ReadLine()); // Ввели Х и У у первой точки

Console.WriteLine("Введите координату второй точки: ");
Console.Write("X2 = ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Y2 = ");
double Y2 = double.Parse(Console.ReadLine()); // Ввели Х и У у второй точки

// Формула расстояния между 2 точками в 2D:
// AB = √(xb - xa)2 + (yb - ya)2

//Math.Sqrt - возвращает квадратный корень
//Math.Pow - возведение в квадрат
//Double - Десятичная дробь (int - целое число)

Console.Write($"A ({X1},{Y1}); B({X2},{Y2}) -> "); // Выводим часть ответа (из условия)
double L = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)); // Подставляем в формулу переменные, используя мат. методы
Console.Write(Math.Round(L, 2)); // Округляем до 2 знаков
