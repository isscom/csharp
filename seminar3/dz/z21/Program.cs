// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату первой точки: ");
Console.Write("X1 = ");
double X1 = double.Parse(Console.ReadLine());

Console.Write("Y1 = ");
double Y1 = double.Parse(Console.ReadLine());

Console.Write("Z1 = ");
double Z1 = double.Parse(Console.ReadLine()); // Ввели Х, Y, Z у первой точки

Console.WriteLine("Введите координату второй точки: ");
Console.Write("X2 = ");
double X2 = double.Parse(Console.ReadLine());

Console.Write("Y2 = ");
double Y2 = double.Parse(Console.ReadLine());

Console.Write("Z2 = ");
double Z2 = double.Parse(Console.ReadLine()); // Ввели Х, Y, Z у второй точки

Console.Write($"A ({X1},{Y1},{Z1}; B ({X2},{Y2},{Z2}) -> "); // Выводим часть ответа

// Формула расстояния между двумя точками в 3D: AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double L = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2)); // Подставляем в формулу наши координаты
Console.Write(Math.Round(L, 2)); // Округляем до 2 знаков
