// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

bool CheckRepeat(int[,,] array, int elemPos, int elemVal) // Проверка элемента 3D массива на дубли (правда/ложь)
//     аргумент 1: 3D массив //кол-во элементов //искомый элемент
{
    int pos = 0; // начинаем с нулевого элемента массива
    foreach (int element in array) // перебераем элементы в массиве
    {
        if (element == elemVal && pos < elemPos) return true; // если элемент равен искомому элементу и позиция меньше кол-ва элементов, то правда
        pos++; // переходим к следующему элементу массива
    }
    return false; // иначе ложь
}

void Print3D (int[,,] array) // Метод вывода 3D массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"[{i},{j},{k}] = {array[i,j,k]}");
            }
        }
    }
}

void Random3D (int[,,] array) // Метод заполнения 3D массива (внутри метод генерации)
{
    bool repeat = true; // повторяемость правда
    int counter = 0; // счетчик
    int rndVal = 0; // значение элемента
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                while (repeat)
                    {
                        rndVal = new Random().Next(10, 100);
                        repeat = CheckRepeat(array, counter, rndVal); // проверяем на дубли сгенерированное выше значение в массиве
                    }
                        array[x,y,z]=rndVal; // присваиваем элементу массива уникальное значение
                        repeat = true;
                        counter++; // увеличиваем счетчик
            }
        }
    }
}

Console.Clear();

int a = 2;
int b = 2;
int c = 2;
int[,,] matrix = new int[a,b,c];

int position = 0;
Random3D(matrix);
Print3D(matrix);