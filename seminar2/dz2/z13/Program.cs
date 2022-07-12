﻿//Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Задайте число: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"{N} -> "); // Выводим часть ответа

if (N < 100 && N > -100) // Если число имеет менее 3 знаков
    {
        Console.WriteLine ("третьей цифры нет"); // то пишем, что третьей цифры нет
    }
else
    {
        if (N > 999 || N < -999) // Если число имеет более 3 знака
            {
                int triple = N / 10; // Вводим переменную, в которую нужно положить первые 3 цифры
                while (triple > 999 || triple < -999) // Пока эта переменная имеет больше, чем 3 цифры
                    {
                        triple = triple / 10; // Делим её на 10 (убираем последнюю цифру)
                    }
                if (triple > 0) // Если переменная положительная
                    {
                        Console.WriteLine (triple % 10); // Выводим последнюю цифру переменной на экран (3 цифра числа N)
                    }
                else
                    {
                        Console.WriteLine (triple % 10 * -1); // Иначе (если переменная отрицательная) - также выводим последнюю цифру (3 цифра числа N)
                    }
            }
        else // Иначе (т.е. если не выполняются условия (число более 3 знака, число менее 3 знака) => ЧИСЛО ИМЕЕТ РОВНО 3 ЗНАКА И НАМ НАДО ВЫВЕСТИ ПОСЛ. ЦИФРУ)
            {
                if (N > 0)
                    {
                        Console.Write(N % 10); // Остаток от деления на 10 даёт третью цифру положительного трехачного числа (последнюю цифру любого положительного числа)
                    }
                else
                    {
                        Console.Write(N % 10 * -1); // Умножаем на -1 для получение именно цифры, а не значения
                    }
            }
    }