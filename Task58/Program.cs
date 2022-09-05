// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrixResult.GetLength(0); i++)
        {
            for (int j = 0; j < matrixResult.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        PrinMatrix(matrixResult);
    }
    else Console.WriteLine("Матрицы невозможно перемножить.");
}

int[,] matr1 = CreateMatrixRndInt(2, 2, 1, 3);
PrinMatrix(matr1);
Console.WriteLine();

int[,] matr2 = CreateMatrixRndInt(2, 2, 1, 3);
PrinMatrix(matr2);
Console.WriteLine();

MultMatrix(matr1, matr2);