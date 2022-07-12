// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

void printArray(int[,] mass) {                        //метод печатает двумерный массив
    for (int i = 0; i < mass.GetLength(0); i++) {
        for (int j = 0; j < mass.GetLength(1); j++) {
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void fillArray(int[,] coll) {                         //метод заполняет двумерный массив
    for (int i = 0; i < coll.GetLength(0); i++) {
        for (int j = 0; j < coll.GetLength(1); j++) {
           coll[i,j] = new Random().Next(0, 10);
        }
    }
}

void findRowSum(int[,] matr, int[] collection) {      //метод суммирует элементы строк и записывает их суммы в простой массив
    for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++) {
            collection[i] += matr[i,j];               //элементы каждой строки суммируем и записываем в отдельную ячейку простого массива                         
        }
        Console.WriteLine("Сумма элементов строки с индексом " + i + " = " + collection[i]);
    }
    Console.WriteLine();
}

void findMinRow(int[] collection) {                   //метод находит строку с мин. суммой в простом массиве
    int index = 0;                                    //определяем начальный индекс, который будет обновляться из стр.39
    int min = collection[index];                      //определяем начальное мин. элемент с которым будем сравнивать все последующие
    for (int i = 0; i < collection.Length; i++) {     //перебираем простой массив
        if (collection[i] < min) {                    //если начальный мин. элемент меньше нового элемента, тогда   
            index = i;                                //сохраняем индекс нового элемента
            min = collection[i];                      //новый элемент сохраняем в переменную min
        }
    }
    Console.WriteLine("Строка с наименьшей суммой = " + min + " имеет индекс: " + index);
}

Console.Write("Введите кол-во строк двумерного массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array2d = new int[n,m];
int[] array = new int[array2d.GetLength(0)] ; //создаем простой массив нужной размерности
fillArray(array2d);                           //заполняем двумерный массив
printArray(array2d);                          //печатаем двумерный массив
findRowSum(array2d, array);                   //находим сумму элементов каждой строки и записываем ее в простой массив
findMinRow(array);                            //находим минимальную сумму в простом массиве с указанием ее индека
