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
