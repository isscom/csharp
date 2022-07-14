// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] fuzzySort(int[,] arr)
    {
        int temp = 0;
        for (int i = 0; i <= arr.GetLength(0) - 1; i++)
            { 
                for (int j = 0; j <= arr.GetLength(1) - 1; j++)
                    {
                        for (int k = j + 1; k <= arr.GetLength(1) - 1; k++)
                            {
                                if (arr[i, j] < arr[i, k])
                                    { 
                                        temp = arr[i, j];
                                        arr[i, j] = arr[i, k];
                                        arr[i, k] = temp;
                                    }
                            }
                    }
            }
        return arr;
    }

int[,] SortArray(int[,] array3)
    {
        int temp = 0; // Вводим переменную - буфер (для обмена)
        for (int i = 0; i < array3.GetLength(0); i++) // Пробегаемся по каждой строке внешним циклом
        {
            for (int j = 0; j < array3.GetLength(1); j++) // Пробегаемся по каждому столбцу внутренним циклом
            {
                for (int k = j+1; k < array3.GetLength(1); k++) // Пробегаемся еще одним внутрениим циклом по следующему столбцу после j
                {
                    if (array3[i, j] < array3[i, k]) // Если элемент строки в столбце j меньше, чем в столбце k
                        {
                            temp = array3[i, j]; // в буфер вставляем элемент строки в столбце j
                            array3[i, j] = array3[i, k]; // в элемент столбца j записываем элемент столбца k
                            array3[i, k] = temp; // в элемент столбца k записываем из буфера значение
                        }
                }
            }
        }
        return array3; // возвращаем массив
    }


Console.Write("Введите кол-во строк двумерного массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[n,m];
RandomArray(array);
Console.WriteLine("Несортированный массив: ");
PrintArray(array);
Console.WriteLine("Отсортированные по убыванию строки массива: ");
PrintArray(SortArray(array));