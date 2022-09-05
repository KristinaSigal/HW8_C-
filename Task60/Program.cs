// Задача 60. 
// 1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// 2. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrixRndInt(int row, int col, int dep)
{
    int[] arrSors = new int[90];
    for (int i = 0; i < 90; i++)
    {
        arrSors[i] = i + 10;
    }
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int next = rnd.Next(0, 89);
                while (arrSors[next] == 0)
                {
                    next = rnd.Next(0, 89);
                }
                matrix[i, j, k] = arrSors[next];
                arrSors[next] = 0;
            }
        }
    }
    return matrix;
}

void PrinMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

PrinMatrix(CreateMatrixRndInt(2, 2, 2));