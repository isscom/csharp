// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void PrintArray (int[,] ArrayForPrint, string Name) // Метод вывода матрицы на экран с указанием её названия
{
    Console.WriteLine(Name);
    for (int i = 0; i < ArrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayForPrint.GetLength(1); j++)
        {
            Console.Write(ArrayForPrint[i, j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void RandomArray (int[,] ArrayRandom) // Метод заполнения матрицы случайными числами
{
    for (int i = 0; i < ArrayRandom.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayRandom.GetLength(1); j++)
        {
            ArrayRandom[i,j] = new Random().Next(1, 10);
        }
    }
}

void Multiplication (int[,] array1, int[,] array2, int[,] ArrayResult) // Метод вычисления произведения двух матриц
{
    for (int i = 0; i < ArrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayResult.GetLength(1); j++)
        {
            ArrayResult[i, j] = array1[i, j] * array2[i, j];
        }
    }
}

Console.Clear(); // Очистка консоли в начале программы

Console.WriteLine("Введите количество строк матриц: ");
int Rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матриц: ");
int Columns = int.Parse(Console.ReadLine());

int[,] matrix1 = new int[Rows, Columns];
int[,] matrix2 = new int[Rows, Columns];
int[,] MatrixResult = new int[Rows, Columns];

RandomArray(matrix1);
RandomArray(matrix2);
Console.WriteLine();
PrintArray(matrix1, "Первая матрица");
PrintArray(matrix2, "Вторая матрица");

Multiplication(matrix1, matrix2, MatrixResult);
PrintArray(MatrixResult, "Произведение 2-х матриц");