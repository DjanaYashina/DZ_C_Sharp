// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на
// их квадраты.

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
int[,] ChengeMatrix(int[,] matrix)
{
    for (int i=0; i< matrix.GetLength(0); i++)
    {
      for (int j=0; j < matrix.GetLength(1); j++)
      {
        if (i % 2 !=0 && j % 2 !=0)
        {
        matrix [i,j] = matrix [i,j]*matrix [i,j];
        }
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

const int ROWS = 3;
const int COLUMNS = 4;
int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] NewMatrix = ChengeMatrix(myMatrix);
PrintMatrix(NewMatrix);