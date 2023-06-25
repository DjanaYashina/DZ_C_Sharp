// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetRandomArray()
{
    double [] array = new double [5];
     for (int i = 0; i<array.Length; i++)
     {
        array [i] = Random.Shared.Next(0, 100) + Random.Shared.NextDouble();
     }
     return array;
}
double[] array = GetRandomArray();
Console.WriteLine("Новый массив:");
Console.WriteLine($"[ {string.Join(", ", array)} ]");

double MinNum()
{
double MinNumber = array [0];
for (int i = 0; i<array.Length; i++)
     {
        if ( MinNumber > array[i] )
        {
           MinNumber =  array[i];
        }
     }
     return MinNumber;

}

double MaxNum()
{
double MaxNumber = array [0];
for (int i = 0; i<array.Length; i++)
     {
        if (MaxNumber < array[i])
        {
           MaxNumber =  array[i];
        }
     }
     return MaxNumber;
}

double a = MaxNum();
double b = MinNum();
double result = a - b;
Console.WriteLine($"Минимальный элемент массива = {a:f2}");
Console.WriteLine($"Максимальный элемент массива = {b:f2}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result:f2}");