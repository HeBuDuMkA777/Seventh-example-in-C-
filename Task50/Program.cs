using System;
using static System.Console;

Clear();

WriteLine("Введите через пробел номера строки и столбца элемента в двумерном массиве: ");
string[] position = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix = GreatMatrix(new Random().Next(1, 10), new Random().Next(1, 10), -10, 10);
//PrintMatrix(matrix); // печать массива для проверки
WriteLine();
ValueCell(matrix, int.Parse(position[0]), int.Parse(position[1]));


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

void ValueCell(int[,] matrix, int row, int column)
{
    if ((row > matrix.GetLength(0) - 1) || (column > matrix.GetLength(1) - 1))
    {
        WriteLine("Такого элемента нет в массиве");
    }
    else
    {
        WriteLine(matrix[row, column]);
    }
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