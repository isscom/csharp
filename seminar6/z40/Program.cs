// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первое число: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int Y = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int Z = int.Parse(Console.ReadLine()); // Пользователь ввёл три числа

if (X < Y + Z && Y < X + Z && Z < X + Y)
    {
        Console.WriteLine("Треугольник существует");
    }
else
    {
        Console.WriteLine("Треугольник не существует");
    }