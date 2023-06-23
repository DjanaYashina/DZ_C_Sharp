// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,
// 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма
// отрицательных равна -20

int[] GetRandomArray()
{
    int [] array = new int [12];
     for (int i = 0; i<array.Length; i++)
     {
        array [i] = Random.Shared.Next(-9, 10);
     }
     return array;
}

int SumPozitiveElements(int[] massive)
{
    int SumOfPozitiveElements = 0;
    for (int i=0; i<massive.Length; i++)
    {
        if (massive[i]>0)
        {
            // SumOfPozitiveElements=SumOfPozitiveElements+massive
            SumOfPozitiveElements += massive[i];
        }
    }
   return SumOfPozitiveElements;
}

int SumNegativeElements(int[] massive)
{
    int SumNegativeElements = 0;
    for (int i=0; i<massive.Length; i++)
    {
        if (massive[i]<0)
        {
            SumNegativeElements += massive[i];
        }
    }
   return SumNegativeElements;
}

int[] myArray = GetRandomArray();
int SumPoz = SumPozitiveElements(myArray);
int SumNeg = SumNegativeElements(myArray);

Console.WriteLine($"[ {string.Join(", ", myArray)} ]"); // string.Join(", ", myArray) слепляет элементы массива и выводит их  в строку ("," - разделитель, значение)
Console.WriteLine($"Сумма положительных элементов = {SumPoz}");
Console.WriteLine($"Сумма положительных элементов = {SumNeg}");