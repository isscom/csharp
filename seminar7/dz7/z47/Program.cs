// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

//НАЧАЛО МЕТОДА (Вывод на печать двумерного массива)
void Print(double[,] array1)
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

//НАЧАЛО МЕТОДА (Заполнение двумерного массива случайными вещественными числами)
void RandomDouble(double[,] array2)
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = Math.Round(new Random().Next(0, 31) + new Random().NextDouble(), 2);
            }
        }
    }
//КОНЕЦ МЕТОДА

Console.WriteLine("Введите кол-во строк: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int M = int.Parse(Console.ReadLine());
double[,] array = new double[N, M];
Console.WriteLine("");
RandomDouble(array);
Print(array);