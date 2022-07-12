// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

//НАЧАЛО МЕТОДА (вывод массива на экран в квадратных скобках)
void PrintArray (int[] array2)
    {
        Console.Write("[ ");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i] + " ");
        }
        Console.Write("]");
    }
//КОНЕЦ МЕТОДА

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int[] array = new int[N];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < N; i++)
{
    array[i] = array[i-1] + array[i-2];
}

PrintArray(array);
