// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void printArray(int[,] mass) {                             //метод печатает двумерный массив
    for (int i = 0; i < mass.GetLength(0); i++) {
        for (int j = 0; j < mass.GetLength(1); j++) {
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void fillArray(int[,] coll) {                              //метод заполняет двумерный массив
    for (int i = 0; i < coll.GetLength(0); i++) {
        for (int j = 0; j < coll.GetLength(1); j++) {
           coll[i,j] = new Random().Next(0, 10);
        }
    }
}

int [,] createNewArr(int[,] array) {                       //метод вычисляет мин. значение, его координаты, создает новый массив
    int iMin = 0;
    int jMin = 0;                             
    int min = array[iMin, jMin];                           //инициализируем переменную под мин. элемент
        for (int i = 0; i < array.GetLength(0); i++) {     //далее рутина
            for (int j = 0; j < array.GetLength(1); j++) {
                if (array[i, j] < min) {
                    min = array[i, j];
                    iMin = i;
                    jMin = j; 
                }
            }   
        }
        Console.Write("Минимальное значение = " + min + ";");
        Console.WriteLine(" Индекс строки = " + iMin + ";" + " Индекс столбца = " + jMin + ".");
        Console.WriteLine();

    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1]; //создаем новый массив на размер одну размерность меньше
        for (int i = 0; i < newArray.GetLength(0); i++) {
            for (int j = 0; j < newArray.GetLength(1); j++) {
                if (i < iMin && j < jMin) {                    //элементы находящиеся выше и левее перекрестия остаются на месте без изменений. просто копипастим в теже координаты нового массива
                    newArray[i, j] = array[i, j]; 
                } else if (i == iMin && j == jMin && i == j) { //в перекрестие переносим элемент, находящийся ниже по диагонали
                    newArray[i, j] = array[i + 1, j + 1];
                } else if (j >= jMin && i < iMin) {            //элементы находящиеся выше и правее перекрестия, переносим левее
                    newArray[i, j] = array[i, j + 1];
                } else if (i >= iMin && j < jMin) {            //элементы находящиеся ниже и левее перекрестия, переносим выше
                    newArray[i, j] = array[i + 1, j];
                } else if (i != iMin && j != jMin && i == j) { //элементы находящиеся на главной диагонли ниже и правее перекрестия переносим выше по диагонали
                    newArray[i, j] = array[i + 1, j + 1];
                } else {                                   //все остальные элементы находящиеся на второй диагонли ниже и правее перекрестия переносим выше по второй диагонали
                    newArray[i, j] = array[i + 1, j + 1];
                }
            }
        }
        return newArray;
    }

Console.Write("Введите кол-во строк двумерного массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[n,m];
fillArray(array);                             //заполняем двумерный массив
printArray(array);                            //печатаем двумерный массив
printArray(createNewArr(array));              //печатаем новый двумерный массив без строки и столбца содержащих мин. элемент