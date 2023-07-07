//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
const int ROWS = 3;
const int COLUMNS = 3;

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

int[,] MatrixOne = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(MatrixOne);
Console.WriteLine();
int[,] MatrixTwo = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(MatrixTwo);
Console.WriteLine();

int[,] matrix = new int[ROWS, COLUMNS]; 
for (int i=0; i< matrix.GetLength(0); i++)
    {
      for (int j=0; j < matrix.GetLength(1); j++)
      {
        matrix [i,j] = MatrixOne[i,j]*MatrixTwo[i,j];
        Console.Write($"{matrix[i, j]} ");
      } 
      Console.WriteLine(); 
    } 