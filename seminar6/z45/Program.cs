// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

//ВВОД МЕТОДА (заполнение массива случайными трехзначными числами)
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

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] arrayorigin = new int[N]; // Пользователь определяет длину (размер) массива
CreateRandomArray(arrayorigin);
PrintArray(arrayorigin);

int[] arraycopy = new int[arrayorigin.Length]; // Вводим массив, куда скопируем элементы первого массива
for (int j = 0; j < arraycopy.Length; j++)
{
    arraycopy[j] = arrayorigin[j]; // Присваиваем элементу arraycopy значение элемента arrayorigin (одного индекса)
}

Console.WriteLine("");
PrintArray(arraycopy);