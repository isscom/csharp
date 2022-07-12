// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void printArray(int[,] mass)
{                        
    for (int i = 0; i < mass.GetLength(0); i++)
        {     
            for (int j = 0; j < mass.GetLength(1); j++)
                { 
                    Console.Write(mass[i,j] + " ");           
                }
            Console.WriteLine();
        }
    Console.WriteLine();
}

void fillArray(int[,] coll) {                         
    for (int i = 0; i < coll.GetLength(0); i++) {     
        for (int j = 0; j < coll.GetLength(1); j++) { 
           coll[i,j] = new Random().Next(0, 10);      
        }
    }
}

int[,] fuzzySort(int[,] arr) {                                    //метод сортирует строки массива пузырьковой сортировкой
    int temp = 0;
    for (int i = 0; i <= arr.GetLength(0) - 1; i++) {             //перебираем строки i
        for (int j = 0; j <= arr.GetLength(1) - 1; j++) {         //перебираем столбцы j
            for (int k = j + 1; k <= arr.GetLength(1) - 1; k++) { //счетчик для столбцов k вместо j + 1, чтобы не вылетать за границы массива
                if (arr[i, j] < arr[i, k]) {                      //сравниваем ячейки между собой
                    temp = arr[i, j];                             //меняем местам переменные согласно условию сортировки
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}  

Console.Write("Введите кол-во строк двумерного массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[n,m];
fillArray(array);                        //заполняем массив
Console.WriteLine("Несортированный массив: ");
printArray(array);                       //печатаем массив
Console.WriteLine("Отсортированные по убыванию строки массива: ");
printArray(fuzzySort(array));            //печатаем отсортированный массив, передавая в него метод fuzzySort

////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void printArray(int[,] mass) {                            //метод печатает двумерный массив
    for (int i = 0; i < mass.GetLength(0); i++) {         //перебираем строки i
        for (int j = 0; j < mass.GetLength(1); j++) {     //перебираем столбцы j
            Console.Write(mass[i,j] + " ");               //печатаем значения элементов
        }
        Console.WriteLine();
    }
}

void fillArray(int[,] matrix) {                          //метод заполняет двумерный массив
    for (int i = 0; i < matrix.GetLength(0); i++) {      //перебираем строки i
        for (int j = 0; j < matrix.GetLength(1); j++) {  //перебираем столбцы j
           matrix[i,j] = new Random().Next(0, 10);       //генерируем случайные значения
        }
    }
}

void Multiplication(int[,] arr, int[,] arr2, int[,] arr3) {      //метод перемножает значения массивов array1 и array2
    for (int i = 0; i < arr.GetLength(0); i++) {                 //перебираем строки i массива arr
        for (int j = 0; j < arr2.GetLength(1); j++) {            //перебираем столбцы j массива arr2
            arr3[i,j] = arr[i,j] * arr2[i,j];                    //записываем в arr3 перемноженный значения arr1 и arr2
            Console.Write(arr3[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int m = int.Parse(Console.ReadLine());
// Второй массив будет с противоположными значениями
int[,] mass1 = new int[n,m];
Console.WriteLine();
fillArray(mass1);
Console.WriteLine("Массив mass1:");
printArray(mass1);
int[,] mass2 = new int[m,n];
Console.WriteLine();
fillArray(mass2);
Console.WriteLine("Массив mass2:");
printArray(mass2);
Console.WriteLine();
int[,] mass3 = new int[n,n];
Console.WriteLine("Массив mass3 c перемноженными значениями:");
Multiplication(mass1, mass2, mass3);

////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 62: Заполните спирально массив 4 на 4.

void printArray(int[,] array) {                                //метод печатает двумерный массив
    for (int i = 0; i < array.GetLength(0); i++) {      //перебираем строки i
        for (int j = 0; j < array.GetLength(1); j++) {  //перебираем столбцы j
            Console.Write(array[i,j] + " ");            //печатаем значения элементов
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void spiralArray(int[,] matrix) {                              //метод заполняет двумерный массив спиралькой
/* устнавливаем границы двумерного массива используя понятные,
/* в первую очередь человеку, имена переменных */
    int rowStart = 0;                                          //начало строки = индекс 0
    int rowEnd = matrix.GetLength(0) - 1;                      //конец строки = последнему индексу строки
    int columnStart = 0;                                       //начало столбца = индекс 0
    int columnEnd = matrix.GetLength(1) - 1;                   //конец столбца = последнему индексу столбца
    int num = 1;                                               //начальное значение элемента, которое будем инкрементировать двигаясь по массиву

    while (columnStart <= columnEnd && rowStart <= rowEnd) {   //пока индексы находятся в границах массива 
/* находимся в левом верхнем углу пустого массива */
        for (int i = 0; i <= columnEnd; i++) {                 //1-й цикл → слева направо перебирает ячейки верхней пустой строки. важно, ЯЧЕЙКИ в строке двумерного массива - это СТОЛБЦЫ двумерного массива
            matrix[rowStart,i] = num++;                        //инкрементируемое значение записывается в ячейки этой строки
        }
        rowStart++;                                            //переходим на одну строку ниже ↓, чтобы исключить заполненную строку из дальнейших операций
/* находимся в правом верхнем углу пустого массива */
        for (int i = rowStart; i <= rowEnd; i++) {             //2-й цикл ↓ сверху вниз перебирает ячейки последнего пустого столбца. важно, ЯЧЕЙКИ в столбце двумерного массива - это СТРОКИ двумерного массива
            matrix[i,columnEnd] = num++;                       //инкрементируемое значение записывается в ячейки этого столбца
        }
        columnEnd--;                                           //переходим на один столбец левее ←, чтобы исключить заполненный столбец из дальнейших операций
/* находимся в правом нижнем углу пустого массива */
        if (rowStart <= rowEnd) {                              //проверяем, есть ли еще пустые строки
           for (int i = columnEnd; i >= columnStart; i--) {    //3-й цикл ← справа налево перебирает ячейки последней пустой строки
               matrix[rowEnd, i] = num++;                      //инкрементируемое значение записывается в ячейки этой строки
           }
        } 
        rowEnd--;                                              //переходим на одну строку выше ↑, чтобы исключить заполненную строку из дальнейших операций
/* находимся в левом нижнем углу пустого массива */
        if (columnStart < columnEnd) {                         //проверяем, есть ли еще пустые столбцы
           for (int i = rowEnd; i > rowStart; i--) {           //4-й цикл ↑ снизу вверх перебирает ячейки левого пустого столбца
               matrix[i, columnStart] = num++;                 //инкрементируемое значение записывается в ячейки этого столбца
           }
        }
        columnStart++;                                         //переходим на один столбец правее →, чтобы исключить заполненный столбец из дальнейших операций
    }                                                          //затем возвращаемся к циклу while и пока его условие выполняется, снова пробегаем по циклам
}

Console.Write("Введите количество строк двумерного массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int column = int.Parse(Console.ReadLine());
int[,] mass = new int[row,column];
spiralArray(mass);                                             //вызываем метод заполняющий массив
printArray(mass);                                              //вызываем метод печатающий массив