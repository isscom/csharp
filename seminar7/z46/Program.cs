// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

//НАЧАЛО МЕТОДА
//Вывод двумерного массива на экран
void Print(int[,] array1)
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

//НАЧАЛО МЕТОДА
//Заполнение двумерного массива случайными числами
void Random(int[,] array2)
{
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(-100, 101);
    }
}
}
//КОНЕЦ МЕТОДА

Console.WriteLine("Введите кол-во строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine());
// int m = 3, n = 4; // Инициализируем 2 переменные вручную (строки, столбцы)
int[,] array = new int[m, n]; // Инициализируем двумерный массив (m, n берем с клавиатуры)
Random(array);
Print(array);