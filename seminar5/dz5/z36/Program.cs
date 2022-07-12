// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Берем нечетные индексы, начиная с 1-го (не с 0-го) и складываем

//ВВОД МЕТОДА (заполнение массива случайными числами (от -100 до 100))
void CreateRandomArray (int[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(-100, 101);
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

//НАЧАЛО МЕТОДА (высчитывание суммы элементов с нечетным индексом)
void SumOddIndex (int[] array3)
    {
        int sum = 0;
        for (int i = 1; i < array3.Length; i+=2)
        {
            sum+=array3[i];
        }
        Console.Write(sum);
    }

int[] array = new int[4];
CreateRandomArray(array);
PrintArray(array);
Console.Write(" -> ");
SumOddIndex(array);