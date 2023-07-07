// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] GetSortMatrix(int[,] matrix)
{
   
    for(int i=0; i<matrix.GetLength(0); i++)
    {
       for(int j=0; j<matrix.GetLength(1); j++)
        {
          for(int k=0; k<matrix.GetLength(1)-1; k++)
          {
            if (matrix[i,k]<matrix[i,k+1])
            {       
            int temp = matrix[i,k+1];
            matrix[i,k+1] = matrix[i,k];
            matrix[i,k] = temp;
            }
          }
        }

    }
  
  return matrix;
}

const int ROWS = 4;
const int COLUMNS = 4;
int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] SortMatrix = GetSortMatrix(myMatrix);
PrintMatrix(myMatrix);