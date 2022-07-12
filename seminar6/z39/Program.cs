// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//ВВОД МЕТОДА (заполнение массива случайными числами от 1 до 9)
void CreateRandomArray (int[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(1, 10);
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

//НАЧАЛО МЕТОДА (разворот массива / замена элементов через буфер)
void ReverceArray (int[] array3)
    {
        int help; // Вспомогательная переменная (буфер)
        for (int i = 0; i < array3.Length / 2; i++) // пробегаем с 0 элемента массива до среднего (полдлины)
            {
                help = array3[i]; // Присваиваем переменной (буферу), значение рабочего элемента
                array3[i] = array3[array3.Length - 1 - i]; // В рабочий элемент массива ставим последний элемент массива (array3.Length - 1, т.к. index начинается с 0, а длина массива указана в кол-ве) минус i (чтобы ставить симметричный элемент)
                array3[array3.Length - 1 - i] = help; // В последний элемент (минус i) ставим элемент из буфера
            }
        return;
    }
//КОНЕЦ МЕТОДА

int[] array = new int[4];
CreateRandomArray(array);
PrintArray(array);
Console.Write(" -> ");
ReverceArray(array);
PrintArray(array);