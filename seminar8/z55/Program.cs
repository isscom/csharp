// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");

int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

Console.WriteLine("");
Console.WriteLine("Задался массив: ");
Random(array);
Print(array);

if (n != m)
    {
        Console.WriteLine("Замена строк на столбцы не возможна!");
        Console.WriteLine("Матрица не квадратная!");
    }
else
    {
        int buffer;
        for (n = 0; n < array.GetLength(0); n++) // Пробегаемся по всем строчкам
        {
            for (m = n; m < array.GetLength(1); m++) // Идём "уголком"
            {
                buffer = array[n,m];
                array[n, m] = array[m, n]; // Меняем [n,m] на [m,n]
                array[m, n] = buffer;
            }
        }
Console.WriteLine("");
Console.WriteLine("Замена строк на столбцы: ");
Print(array);
    }