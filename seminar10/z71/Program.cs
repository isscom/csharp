// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
// и «в». Покажите все слова, состоящие из n букв, которые можно построить из
// букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс

Console.Clear();
string[] Words(string[] alf, int number)
{
if (number == 0)
{
string[] res = new string[1];
res[0] = "";
return res;
};

string[] temp = Words(alf, number - 1);
string[] result = new string[temp.Length * alf.Length];
int index = 0;
for (int i = 0; i < temp.Length; i++)
{
for (int j = 0; j < alf.Length; j++)
{
result[index] = temp[i] + alf[j];
index++;
}
}
return result;
}

string[] alf = { "а", "с", "и", "в", "Ж" };
Console.WriteLine("Введите N");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
string[] result = Words(alf, number);

for (int i = 0; i < result.Length; i++)
{
Console.Write(i + " " + result[i] + " ");
}