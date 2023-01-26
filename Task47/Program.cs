using System;
using static System.Console;

Clear();

WriteLine("Введите количество строк двумерного массива: ");
int row = int.Parse(ReadLine());
WriteLine("Введите количество столбцов двумерного массива: ");
int column = int.Parse(ReadLine());
int[,] matrix = GreatMatrix(row, column, -10, 10);
PrintMatrix(matrix);



int[,] GreatMatrix(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Write($"{Array[i,j]} ");
        }
        WriteLine();
    }
}