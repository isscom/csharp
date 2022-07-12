// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//НАЧАЛО МЕТОДА (вывод массива на экран)
void PrintArray (int[] array1)
    {
        Console.Write("[ ");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write(array1[i] + " ");
        }
        Console.Write("]");
    }
//КОНЕЦ МЕТОДА

//НАЧАЛО МЕТОДА (поиск кол-ва чисел больше 0)
void SearchNumbGreaterZero (int[] array2)
    {
        int GZ = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            if (array2[i] > 0)
            {
                GZ++;
            }
        }
        Console.Write(GZ);
    }
//КОНЕЦ МЕТОДА

int M = 5; // В коде определяем число М

int[] array = new int[M];
Console.WriteLine($"Введите {M} чисел: "); // Просим пользователя ввести М чисел
for (int i = 0; i < M; i++)
{
    int N = int.Parse(Console.ReadLine()); // Считываем их и записываем в массив
    array[i] = N;
}

Console.WriteLine("");
PrintArray(array); // Выводим массив
Console.Write(" -> ");
SearchNumbGreaterZero(array); // Выводим кол-во числе больше 0
