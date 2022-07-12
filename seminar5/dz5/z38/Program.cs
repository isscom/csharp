// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

// [3 7 22 2 78] -> 76

//НАЧАЛО МЕТОДА (заполнение массива вещественными числами)
void CreateRandomArray (double[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(0, 101) + new Random().NextDouble();
            array1[i] = double.Round(array1[i], 3, MidpointRounding.ToEven);
        }
    }
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА (вывод массива на экран в квадратных скобках)
void PrintArray (double[] array2)
    {
        Console.Write("[ ");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i] + " ");
        }
        Console.Write("]");
    }
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА (поиск максимального)
double FindMax(double[] array3)
    {
        double max = array3[0]; // Вводим переменную, где будет максимальный элемент массива (пока это элемент с индексом 0)
        for (int i = 1; i < array3.Length; i++) // Цикл пробегает с 1 до конца
            {
                if (max < array3[i]) // Если рабочий элемент больше максимального
                    {
                        max = array3[i]; // В максимальный кладем рабочий
                    }
            }
        //Console.Write("Максимальное: " + max); // Выводим его на экран
        return(max);
    }
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА (поиск минимального)
double FindMin(double[] array4)
    {
        double min = array4[0]; // Вводим переменную, где будет минимальный элемент массива (пока это элемент с индексом 0)
        for (int i = 1; i < array4.Length; i++) // Цикл пробегает с 1 до конца
            {
                if (min > array4[i]) // Если рабочий элемент меньше минимального
                    {
                        min = array4[i]; // В минимальный кладем рабочий
                    }
            }
        //Console.Write("Минимальное: " + min); // Выводим его на экран
        return(min);
    }
//КОНЕЦ МЕТОДА

double[] array = new double[4];
CreateRandomArray(array);
PrintArray(array);
Console.WriteLine("");
FindMax(array);
Console.WriteLine("");
FindMin(array);
Console.WriteLine(FindMax(array) - FindMin(array));