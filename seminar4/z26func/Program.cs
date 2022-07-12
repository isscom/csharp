﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int func(int number) // Объявляем метод (функцию) с параметром number (целое число)
// (int - т.к. метод прозводит вычисления: принимает данные и выдает данные после вычислений)
{
    int count = 0; // заводим счетчик в функции
    while (number !=0) // пока параметр (переменная number) не равна 0
    {
        number = number / 10; // делим параметр на 10 (убираем 1 цифру)
        count++; // увеличиваем счетчик
    }
    return count;
    //Console.WriteLine($"-> {count}");
}
// Конец метода

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.Write(N); // приём на вход числа и вывод его на экран (часть ответа)

Console.WriteLine($" -> {func(N)}"); // вывод на экран следующей части ответа с вызовом функции, описанной выше (функции описываются всегда с самого верха кода)