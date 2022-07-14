// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

bool CheckRepeat(int[,,] array, int elemPos, int elemVal) // Проверка элемента 3D массива на дубли
{
    int pos = 0;
    foreach (int element in array)
    {
        if (element == elemVal && pos < elemPos) return true;
        pos++;
    }
    return false;
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
    bool repeat = true;
    int counter = 0;
    int rndVal = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                while (repeat)
                    {
                        rndVal = new Random().Next(1, 9);
                        repeat=CheckRepeat(array, counter, rndVal);
                    }
                        array[x,y,z]=rndVal;
                        repeat = true;
                        counter++;
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