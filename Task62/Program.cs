// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Spiral()
{
    int[,] result = new int[4, 4];

    int N = 1;
    int stepI = 0;
    int stepJ = 1;

    void SetValue(int i, int j)
    {
        if (N < 17)
        {
            result[i, j] = N;
            N++;
            if (i + stepI < 4 && j + stepJ < 4 && i + stepI >= 0 && j + stepJ >= 0 && result[i + stepI, j + stepJ] == 0)
            {
                SetValue(i + stepI, j + stepJ);
            }
            else
            {
                if (stepI == 0 && stepJ == 1)
                {
                    stepI = 1;
                    stepJ = 0;
                }
                else if (stepI == 1 && stepJ == 0)
                {
                    stepI = 0;
                    stepJ = -1;
                }
                else if (stepI == 0 && stepJ == -1)
                {
                    stepI = -1;
                    stepJ = 0;
                }
                else if (stepI == -1 && stepJ == 0)
                {
                    stepI = 0;
                    stepJ = 1;
                }
                SetValue(i + stepI, j + stepJ);
            }
        }
    }
    SetValue(0, 0);
    return result;
}
void PrinMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}, ");

        }
        Console.WriteLine("]");
    }
}

PrinMatrix(Spiral());