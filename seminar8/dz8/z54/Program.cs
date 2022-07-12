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