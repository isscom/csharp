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
Console.WriteLine($"Введите {M} чисел: ");
for (int i = 0; i < M; i++)
{
    int N = int.Parse(Console.ReadLine());
    array[i] = N;
}

Console.WriteLine("");
PrintArray(array);
Console.Write(" -> ");
SearchNumbGreaterZero(array);

///////////////////////////////////////////////////////

// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) // в примере ошибка (исправлен ответ)

Console.WriteLine("Введите координату b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату k2: ");
double k2 = double.Parse(Console.ReadLine());

double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round(((k1 * b2) - (k2 * b1)) / (k1 - k2), 2);

if (((k1 * x) + b1) == ((k2 * x) + b2))
    {
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y}).");
    }
else
{
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> Линии не пересекаются");
}

