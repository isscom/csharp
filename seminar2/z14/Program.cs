﻿// Задача 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()); // Вводим число и сохраняем его в переменной

// Вариант решения 1 (математический)
int P = 7*23; // Заводим переменную, которая равна произведению и 7 и 23 (из условий задачи)
if (N % P == 0) // Если остаток от деления равен нулю, значит число N кратно одновременно 7 и 23
    {
        Console.WriteLine("да (математический вариант) "); // Пишем ДА
    }
else
    {
        Console.WriteLine("нет (математический вариант) "); // Иначе (если остаток от деления не равен 0), то пишем НЕТ
    }

// Вариант решения 2 (одновременное выполнение 2 условий)

if (N % 7 == 0 && N % 23 == 0)
    {
        Console.WriteLine("да (&& вариант) "); // Пишем ДА
    }
else
    {
        Console.WriteLine("нет (&& вариант) "); // Иначе (если остаток от деления не равен 0), то пишем НЕТ
    }