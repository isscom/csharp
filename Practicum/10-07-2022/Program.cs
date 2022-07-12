



// // 1. Создание
// // 2. Заполнение 
// // 2.1. Подсчета количества нечетных чисел
// // 3. Главная задача  <-- БЛОК-СХЕМОЙ
// // 4. Печать массива

// int[] CreateArray(int count)
// {
//   return new int[count];
// }

// int[] GetData(string path)
// {
//   string[] res = File.ReadAllText(path)
//     .Split(new char[] { ' ', ',', ':', ';' }
//     , StringSplitOptions.RemoveEmptyEntries);
//   int[] numbsInt = new int[res.Count()];

//   for (int i = 0; i < numbsInt.Length; i++)
//   {
//     numbsInt[i] = int.Parse(res[i]);
//   }
//   return numbsInt;
// }

// void Fill(int[] array, int min, int max)
// {
//   int len = array.Length;
//   Random rand = new Random();
//   for (int i = 0; i < len; i++)
//   {
//     array[i] = rand.Next(min, max);
//   }
// }

// int[] MainTask(int[] inputArray)
// {
//   int CountElements(int[] array)
//   {
//     int result = 0;
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//       if (array[i] % 2 == 0) result++;
//     }
//     return result;

//   }

//   int[] outputArray = new int[CountElements(inputArray)];
//   int count = inputArray.Length;
//   int index = 0;
//   int i = 0;
//   while (i < count)
//   {
//     if (inputArray[i] % 2 == 0)
//     {
//       outputArray[index] = inputArray[i];
//       index = index + 1;
//     }
//     i = i + 1;
//   }
//   return outputArray;
// }


// // void Print(int[] array)
// // {
// //   int length = array.Length;
// //   for (int i = 0; i < length; i++)
// //   {
// //     Console.Write($"{array[i]} ");
// //   }
// //   Console.WriteLine();
// // }

// string Print(int[] array)
// {
//   int length = array.Length;
//   string output = String.Empty;
//   for (int i = 0; i < length; i++)
//   {
//     output += ($"array[{i + 1}]: {array[i]} \n");
//   }
//   return output;
// }

// // int[] a = CreateArray(10);
// int[] a = GetData("inputdata.txt");
// //Fill(a, 0, 10);

// string input = Print(a);
// //Console.WriteLine($"input {input}");
// File.WriteAllText("input.txt", input);

// int[] b = MainTask(a);
// string output = Print(b);
// //Console.WriteLine($"output {output}");
// File.WriteAllText("output.txt", output);
