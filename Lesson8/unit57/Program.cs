// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных. Элементы [0, 9]

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
int[] GetFrequencyOfElementsInMatrix(int[,] MyTwoDimensionalArray)
{
    int[] FrequencyArray = new int[10]; // [0,1,2,3,4,5,6,7,8,9]
    int rowCount = MyTwoDimensionalArray.GetLength(0);
    int columnCount = MyTwoDimensionalArray.GetLength(1);
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
            FrequencyArray[MyTwoDimensionalArray[i, j]]++;
    return FrequencyArray;
}
Console.WriteLine("Task#57");

int[,] GMatrix = GetRandomArray(rows, columns);
PrintMatrixInts(GMatrix);
int[] GFrequency = GetFrequencyOfElementsInMatrix(GMatrix);
for (int i = 0; i < GFrequency.Length; ++i)
{
    Console.Write($"{i} : {GFrequency[i]} | ");
}
Console.WriteLine();



// Console.WriteLine("Введите количество строк");
// int zz=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int rz=Convert.ToInt32(Console.ReadLine());
// int[,] a=new int[rz,zz];
// for(int i=0;i<rz;i++){
//     for(int j=0;j<zz;j++){
        
//         a[i,j]=Random.Shared.Next(0,10);
        

        
//     }
// }
// for(int i=0;i<rz;i++){
//     for(int j=0;j<zz;j++){
//         Console.Write("{0,3}", a[i, j]);
        
//     }
//     Console.WriteLine();
// }
// for(int g=0;g<10;g++){
//     int count=0;
//     for(int i=0;i<rz;i++){
//         for(int j=0;j<zz;j++){
//             if(a[i,j]==g){
//                 count++;

//             }
//         }
//     }
//     Console.WriteLine($"{g} встречается {count} раз");}