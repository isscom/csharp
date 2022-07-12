// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//НАЧАЛО МЕТОДА (Вывод двумерного массива на экран)
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
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА (Заполнение двумерного массива случайными числами от 0 до 40)
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
//КОНЕЦ МЕТОДА

Console.WriteLine("Введите кол-во строк: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int M = int.Parse(Console.ReadLine());

int[,] array = new int[N, M];
RandomArray(array);
Console.WriteLine("");
PrintArray(array);
Console.WriteLine("");

Console.WriteLine("Введите index строки искомого элемента: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите index столбца искомого элемента: ");
int Y = int.Parse(Console.ReadLine());

if (X < N && Y < M)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == X && j == Y)
                    {
                        Console.Write($"[{X}, {Y}] -> {array[i, j]}");
                        break;
                    }
            }
    }
}
else
{
    Console.Write($"[{X}, {Y}] -> такого элемента в массиве нет");
}