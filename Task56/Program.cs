// Задача 56: 
// 1.Задайте прямоугольный двумерный массив. 
// 2.Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrinMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void SumRowMatrix(int[,] matrix)
{
    int rowNumber = 0;
    int sumMinRow = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (sumRow < sumMinRow)
        {
            sumMinRow = sumRow;
            rowNumber = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов:{rowNumber}");
}

int[,] matr = CreateMatrixRndInt(7, 4, 1, 9);
PrinMatrix(matr);
Console.WriteLine();
SumRowMatrix(matr);