﻿// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
//
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1

/* 1. Задаем data и info */
/* 2. Переводим в десятичную систему исчисления */

Console.Clear();

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};

int[] cdata = new int [info.Length];

int k = 0;

for (int i = 0; i < info.Length; i++)
{
    for (int j = info[i]-1; j >= 0; j--)
    {
        Console.Write ($"{data[j+k]} ");
        cdata[i] += (in)(data[j+k]*Math.Pow(2,j));
    }
    Console.WriteLie(cdata[i]);
    k+=info[i];
    Console.WriteLine();
}



