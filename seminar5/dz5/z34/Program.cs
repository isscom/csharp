// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

// [345, 897, 568, 234] -> 2

//ВВОД МЕТОДА (заполнение массива случайными 3-значными числами)
void CreateRandomArray (int[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(100, 1000);
        }
    }
//КОНЕЦ МЕТОДА

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

//НАЧАЛО МЕТОДА (поиск кол-ва четных чисел)
void FindEven (int[] array3)
    {
        int count = 0;
        for (int i = 0; i < array3.Length; i++)
        {
            if (array3[i] %2 == 0)
                {
                    count++;
                }
        }
        Console.Write(count);
    }
//КОНЕЦ МЕТОДА

int[] array = new int[4];
CreateRandomArray(array);
PrintArray(array);
Console.Write(" -> ");
FindEven(array);