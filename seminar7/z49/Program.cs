// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
Console.WriteLine("Изначальный массив:"); // Отступаем строку

Random(array);
Print(array);

for (int i = 0; i < array.GetLength(0); i+=2) // Перебираем четные индексы i
{
    for (int j = 0; j < array.GetLength(1); j+=2) // Перебираем четные индексы j
    {
        array[i,j] = array[i, j] * array[i, j]; // Возводим в квадрат, если оба индекса i и j четные
    }
}

Console.WriteLine("Новый массив:"); // Отступаем строку
Print(array); // Печатаем результат


