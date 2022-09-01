//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Матрица А ");
int rowsA = 2;
int colsA = 2;
int[,] array = new int[rowsA, colsA];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(11);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Матрица В");
int rowsB = 2;
int colsB = 2;
int[,] arraySecond = new int[rowsB, colsB];

for (int i = 0; i < arraySecond.GetLength(0); i++)
{
    for (int j = 0; j < arraySecond.GetLength(1); j++)
    {
        arraySecond[i, j] = new Random().Next(11);
        Console.Write(arraySecond[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Проиведение матрицы А*В  ");
int rowsC = 2;
int colsC = 2;
int[,] arrayThird = new int[rowsC, colsC];
for (int i = 0; i < arrayThird.GetLength(0); i++)
{
    for (int j = 0; j < arrayThird.GetLength(1); j++)
    {
        arrayThird[0, 0] = array[0, 0] * arraySecond[0, 0] + array[0, 1] * arraySecond[1, 0];
        arrayThird[0, 0] = Convert.ToInt32(arrayThird[0, 0]);

        arrayThird[1, 0] = array[1, 0] * arraySecond[0, 0] + array[1, 0] * arraySecond[1, 0];
        arrayThird[1, 0] = Convert.ToInt32(arrayThird[1, 0]);

        arrayThird[0, 1] = array[0, 0] * arraySecond[0, 1] + array[0, 1] * arraySecond[1, 1];
        arrayThird[0, 1] = Convert.ToInt32(arrayThird[0, 1]);

        arrayThird[1, 1] = array[1, 0] * arraySecond[0, 1] + array[1, 1] * arraySecond[1, 1];
        arrayThird[1, 1] = Convert.ToInt32(arrayThird[1, 1]);

        Console.Write(arrayThird[i, j] + "\t");
    }
    Console.WriteLine();
}
