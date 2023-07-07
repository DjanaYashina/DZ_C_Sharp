//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i=0; i< matrix.GetLength(0); i++)
    {
      for (int j=0; j < matrix.GetLength(1); j++)
      {
        matrix[i,j] = Random.Shared.Next(1, 10);
      }  
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
   for (int i=0; i< matrix.GetLength(0); i++)
    {
      for (int j=0; j < matrix.GetLength(1); j++)
      {
        Console.Write($"{matrix[i, j]} ");
      } 
      Console.WriteLine(); 
    } 

}

void MinSumRows(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;

    for (int i=0; i< matrix.GetLength(1); i++)
    {
      minRow += matrix[0,i];
    }
    for (int i=0; i< matrix.GetLength(0); i++)
    {
        for (int j=0; j< matrix.GetLength(1); j++)
        {
          sumRow += matrix[i,0];
            if (sumRow < minRow)
            {
              minRow = sumRow;
              minSumRow = i;
            }
          sumRow = 0;
        }
    }
    Console.Write($"{minSumRow + 1} строка");
 }


const int ROWS = 4;
const int COLUMNS = 4;
int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine();
MinSumRows(myMatrix);
