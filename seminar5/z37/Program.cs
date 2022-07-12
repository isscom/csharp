﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void CreateRandomArray (int[] array1) // Метод для генерации элементов массива (случайными числами)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(0, 11); // Промежуток от 0 до 10 включительно (заполняем рандомными числами)
        }
    }
//КОНЕЦ МЕТОДА

void PrintArray (int[] array2) // Метод для вывода на экран массива
    {
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i] + " ");
        }
    }
//КОНЕЦ МЕТОДА

Console.Write("Введите размер массива: "); 
int N = int.Parse(Console.ReadLine()); // Пользователь задает размер массива
int[] array = new int[N]; // Вводим массив размера N
CreateRandomArray(array); // Заполняем его рандомными числами от 0 до 10 (вызываем метод, описанный выше)
Console.Write("[ "); // Выделяем массив скобкой в начале
PrintArray(array); // Выводим массив на экран
Console.Write("]"); // Выделяем массив скобкой в конце

Console.Write(" -> "); // После вывода массива ставим стрелочку (как нужно в ответе)

for (int i = 0; i < array.Length / 2; i++) // Цикл, в котором мы пробегаемся по половине массива
{
    int result = array[i] * array[array.Length - 1 - i]; // Вводим переменную с произведением, в котором мы умножаем рабочий элемент на зеркальный с конца
    Console.Write(result + " "); // Выводим на экран произведение
}

if (array.Length %2 != 0) // Если длина массива нечетная
{
    Console.Write(array[array.Length / 2]); // То выводим на экран средний элемент массива
}