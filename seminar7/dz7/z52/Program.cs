﻿// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
            Console.WriteLine("");
    }
}

void RandomArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(0, 41);
        }
    }
}

Console.WriteLine("Введите кол-во строк: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int M = int.Parse(Console.ReadLine());

int[,] array = new int[N, M];
RandomArray(array);
Console.WriteLine("");
PrintArray(array);
Console.WriteLine("");

double sum = 0; // сумма каждого столбца


for (int j = 0; j < array.GetLength(1); j++)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];
    }
    Console.Write(Math.Round(sum/N, 2) + "; ");
    sum = 0;
}