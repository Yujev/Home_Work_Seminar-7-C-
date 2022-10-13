/*Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine();
Console.Clear();

int m = 4, n = 3;
double[,] array = new double[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        array[i, j] = (double)rand.Next(1, 100) / 10;
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(array[i, j] + "\t");
    Console.WriteLine();
}

int M = 4, N = 5;
int[,] array1 = new int[M, N];
double[] avrg = new double[(array1.GetLength(1)) - 1];
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
        array1[i, j] = rand.Next(0, 100);
}
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
        avrg[i] += array1[i, j];
}
Console.WriteLine();
Console.WriteLine("Cреднее арифметическое столбцов массива:");
for (int i = 0; i < avrg.Length; i++)
    Console.Write(avrg[i] / M + "\t");
Console.WriteLine();


