﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

const int rows = 3;
const int columns = 4;
int[,] matrix = new int[rows, columns];
for (int i=0; i< matrix.GetLength(0); i++)
{
    for (int j=0; j < matrix.GetLength(1); j++)
    {
     matrix[i,j] = Random.Shared.Next(1, 10);
     Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();  
}
    

for (int j=0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i=0; i< matrix.GetLength(0); i++)
      {
        sum = matrix[i,j] + sum;
       
      }
     Console.Write($"{ sum / matrix.GetLength(0):f1} "); 
}
