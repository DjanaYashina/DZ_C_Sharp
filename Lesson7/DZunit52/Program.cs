// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] GetRandomMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i=0; i< matrix.GetLength(0); i++)
//     {
//       for (int j=0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = Random.Shared.Next(1, 10);
//       }  
//     }
//     return matrix;
// } 

// void PrintMatrix(int[,] matrix)
// {
//    for (int i=0; i< matrix.GetLength(0); i++)
//     {
//       for (int j=0; j < matrix.GetLength(1); j++)
//       {
//         Console.Write($"{matrix[i, j]} ");
//       } 
//       Console.WriteLine(); 
//     } 

// }


// double MiddleSum(int[,] matrix)
// {
// double middle = 0;
// int sum = 0;
// for (int i=0; i< matrix.GetLength(0); i++)
//     {
//     for (int j=0; j < matrix.GetLength(1); j++)
//       {
//         sum = ;
//         middle = sum/matrix.GetLength(1);
//       }
      
//     }
// return middle; 
// }
// const int ROWS = 3;
// const int COLUMNS = 4;
// int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
// PrintMatrix(myMatrix);

// double MidSum = MiddleSum(myMatrix);
// Console.WriteLine(string.Join(", ",MidSum));

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
// Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0):f2} ");
}
