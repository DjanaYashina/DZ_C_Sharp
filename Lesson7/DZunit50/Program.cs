// Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет это координаты массива

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


int GetMatrix(int[,] matrix)
{
Console.WriteLine("Введите число для определения позиции в строке");
int RowsNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для определения позиции в колонке");
int ColumnsNumber = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (RowsNumber>matrix.GetLength(0) || RowsNumber<0 || ColumnsNumber>matrix.GetLength(1) || ColumnsNumber<0)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    number = matrix[RowsNumber,ColumnsNumber];
    Console.Write("Заданное число = ");
}
return number;
}

const int ROWS = 3;
const int COLUMNS = 4;
int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
int Number = GetMatrix(myMatrix);