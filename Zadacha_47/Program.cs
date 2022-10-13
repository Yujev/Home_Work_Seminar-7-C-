/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

m = 3, n = 4.

1 7 -2 -85

1 -3 8 -9

8 7 -7 9
*/
Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 47: Задайте двумерный массив размером m*n, заполненный случайными целыми числами. ");
Console.WriteLine();
Console.Write("Введи значение  m: \n");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи значение n: \n");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 40 - 20;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double myArray = Math.Round(array[i, j], 1);
            Console.Write(myArray + "   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
