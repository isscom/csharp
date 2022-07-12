// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д

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
Console.WriteLine("Изначально массив задан:");
Random(array);
Print(array);
Console.WriteLine("");

int sum = 0;
Console.Write("Сумма элементов главной диагонали: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = sum + array[i, j];
            Console.Write(array[i, j] + " ");
        }
    }
}
Console.Write("= ");
Console.WriteLine(sum);