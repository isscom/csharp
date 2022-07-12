// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Набор данных                         Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }               0 встречается 2 раза
//                                          1 встречается 1 раз
//                                          2 встречается 1 раз
//                                          8 встречается 1 раз
//                                          9 встречается 3 раза

// 1, 2, 3                                  1 встречается 3 раза
// 4, 6, 1                                  2 встречается 2 раз
// 2, 1, 6                                  3 встречается 1 раз
//                                          4 встречается 1 раз
//                                          6 встречается 2 раза

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

//НАЧАЛО МЕТОДА
//Определение сколько раз встречается элемент массива
void CountFrequency(int[,] arr, int element)
    {
        int count = 0; //Вводим счетчик
        for (int i = 0; i < arr.GetLength(0); i++) //Пробегаемся по строчкам
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        if (arr[i, j] == element) count++; //Если элемент встретился в i,j то увеличиваем счетчик
                    }
            }
        Console.WriteLine($"{element} встречается {count} раз");
    }
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА
//Проверка массива на дубли элементов
bool CheckArray(int[,] arr, int idx, int elem)
    {
        int counter = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (counter==idx) return true;
                        if (arr[i, j] == elem) return false;
                        counter++;
                    }
            }
        return true;
    }
//КОНЕЦ МЕТОДА

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
Random(array);
Console.WriteLine("Исходный массив:");
Print(array);
int counter=0;

foreach (int elem in array)
    {
        if (CheckArray(array, counter, elem)) CountFrequency(array, elem);
        counter++;
    }