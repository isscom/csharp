// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

//НАЧАЛО МЕТОДА
//Вывод массива на экран
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
                        array2[i, j] = new Random().Next(0, 10);
                    }
            }
    }
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА (вывод первой строки двумерного массива)
void PrintFirstRow(int[,] array4)
    {
        for (int j = 0; j < array4.GetLength(1); j++)
            {
                Console.Write(array4[0,j] + " ");
            }
    }
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА (вывод последней строки двумерного массива)
void PrintLastRow(int[,] array5)
    {
        for (int j = 0; j < array5.GetLength(1); j++)
            {
                Console.Write(array5[array5.GetLength(0)-1, j] + " ");
            }
    }
//КОНЕЦ МЕТОДА

Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");

int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

Console.WriteLine("");
Console.WriteLine("Задался массив: ");
Random(array);
Print(array);

// Console.WriteLine("");

// Console.WriteLine("Первая строка: ");
// PrintFirstRow(array);
// Console.WriteLine("");

// Console.WriteLine("Последняя строка: ");
// PrintLastRow(array);
// Console.WriteLine("");

int buffer = 0;
for (n = 0; n < array.GetLength(1); n++) // Пробегаемся по каждому стобцу циклом
    {
        buffer = array[0, n]; // Вводим буфер для обмена значениями и записываем туда значение 1 строки и рабочего столбца
        array[0, n] = array[array.GetLength(0)-1,n]; // Меняем местами значение 1 строки и рабочего столбца с последней строкой и рабочим столбцом n
        array[array.GetLength(0)-1,n] = buffer;
    }

Console.WriteLine("");
Console.WriteLine("Результат: ");
Print(array);