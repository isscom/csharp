// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

if (N < 2)
    {
        Console.WriteLine("Четных чисел от 1 до N не найдено");
    }
else
    {
        int start = 2; // Задаём переменную: Начало строки
        while (start <= N) // Пока переменная меньше, либо равна введенному числу, делать:
            {
                Console.Write($" {start} "); // Выводим её
                start+=2; // Прибавляем к точке два
            }   
                
        Console.WriteLine("- Все чётные числа от 1 до N"); // Для красоты результата
    }