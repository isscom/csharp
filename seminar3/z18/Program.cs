//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер плоскости: ");
int P = int.Parse(Console.ReadLine()); // Пользователь вводит номер плоскости

if (P == 1)
{
    Console.WriteLine("X>0, Y>0"); // В зависимости от номера - выводятся координаты
}
else if (P == 2)
{
    Console.WriteLine("X<0, Y>0");
}
else if (P == 3)
{
    Console.WriteLine("X<0, Y<0");
}
else if (P == 4)
{
    Console.WriteLine("X>0, Y<0");
}
else {Console.WriteLine("Такой плоскости не существует");}