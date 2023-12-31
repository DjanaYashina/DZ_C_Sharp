﻿// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен наименьший элемент массива.

int rows = 4; int columns = 4;
int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    return matrix;
}

void PrintMatrixInts(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] GetPositionMin(int[,] Matrix)
{
    int iPositionMin = 0;
    int jPositionMin = 0;
    int min = Matrix[0,0];
    for (int i = 0; i < Matrix.GetLength(0); ++i)
        for (int j = 0; j < Matrix.GetLength(1); ++j)
        {
            if (Matrix[i,j] < min)
            {
                min = Matrix[i,j];
                iPositionMin = i;
                jPositionMin = j;
            }
        }
    int[] arrayPair = new int[] {iPositionMin,jPositionMin};
    return arrayPair;
}

int[,] RemoveRespectiveRowAndColumn(int[,] Matrix, int[] ArrayToRemove)
{
    int[,] matrixReduced = new int[Matrix.GetLength(0)-1, Matrix.GetLength(1)-1];
    int iShift = 0;
    int jShift = 0;
    for (int i = 0; i < matrixReduced.GetLength(0); ++i)
    {
        if (i == ArrayToRemove[0])
                iShift++;
        for (int j = 0; j < matrixReduced.GetLength(1); ++j)
        {
            if (j == ArrayToRemove[1])
                jShift++;
            matrixReduced[i,j] = Matrix[i+iShift,j+jShift];
        }
        jShift = 0;
    }
    return matrixReduced;
}
Console.WriteLine("Task #59");
Console.WriteLine();
int[,] Matr = GetRandomArray(rows, columns);
int[] array = GetPositionMin(Matr);
PrintMatrixInts(Matr);
Console.WriteLine();
int[,] MatrReduced = RemoveRespectiveRowAndColumn(Matr, array);
PrintMatrixInts(MatrReduced);