/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2
*/
Console.Clear();
int m = 3, n = 4;
double[,] array = new double[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        array[i, j] = (double)rand.Next(-90, 100) / 10;
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(array[i, j] + "\t");
    Console.WriteLine();
}

//Console.WriteLine();
Console.WriteLine("Укажи позицию элемента");
Console.Write("Введи первый индекс : \n");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второй индекс : \n");
n = Convert.ToInt32(Console.ReadLine());
if (m <= array.GetLength(0) || n <= array.GetLength(1))
{
    Console.WriteLine(array[m, n]);
}
else { Console.WriteLine("Такого числа НЕТ! "); }
