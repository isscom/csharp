//Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число N: ");
double N = double.Parse(Console.ReadLine());
Console.Write(N);
Console.Write(" -> "); // Выводим часть ответа

double count = 1; // Вводим переменную, которая начинается с 1

while (count < N) // Пока введенное число больше переменной
    {
        double POW = Math.Pow(count, 2); // Возводим его в квадрат
        Console.Write($"{POW}, ");
        count++;
    }

double POW2 = Math.Pow(N, 2);
Console.Write($"{POW2}."); // Чтобы в ответе была точка (т.к. в цикле while идет запятая после записи в строку)
