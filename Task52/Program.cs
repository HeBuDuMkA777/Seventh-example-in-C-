using System;
using static System.Console;

Clear();

int[,] matrix = GreatMatrix(new Random().Next(1, 10), new Random().Next(1, 10), -10, 10);
PrintMatrix(matrix); //печать массива для проверки
WriteLine();

GetAverageInColumns(matrix);


void GetAverageInColumns(int[,] matrix)
{
    //double average = new double[matrix.GetLength(1)];
    double average = 0;
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            sum += matrix[j,i];
        }
        average = sum / matrix.GetLength(0);
        Write($"{average}, ");
    }
    //return average;
}


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