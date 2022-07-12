﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void CreateRandomArray (int[] array1) // Метод для генерации элементов массива (случайными числами)
{
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(0, 201); // Промежуток от 0 до 200 включительно (заполняем рандомными числами)
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

int[] array = new int[123]; // Инициализируем массив из 123 случайных чисел
CreateRandomArray(array); // Заполняем его рандомными числами от 0 до 200 (вызываем метод, описанный выше)
Console.Write("[ "); // Выделяем массив скобкой в начале
PrintArray(array); // Выводим массив на экран
Console.Write("]"); // Выделяем массив скобкой в конце

int count = 0; // Вводим счётчик (результат)

for (int i = 0; i < array.Length; i++) // Пробегаемся по всем элементам массива
{
    if (array[i] >= 10 && array[i] <= 99) // Если элемент массива удовл. условиям задачи
    {
        count++; // Прибавляем к счётчику 1
    }
}

Console.WriteLine(""); // Добавляем пустую строку
Console.WriteLine("-> " + count); // Выводим полученный счётчик