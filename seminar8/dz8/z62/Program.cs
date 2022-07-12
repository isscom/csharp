﻿// Задача 62: Заполните спирально массив 4 на 4.

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