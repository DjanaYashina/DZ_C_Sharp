// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray()
{
    int [] array = new int [5];
     for (int i = 0; i<array.Length; i++)
     {
        array [i] = Random.Shared.Next(100, 1000);
     }
     return array;
}
int[] array = GetRandomArray();
Console.WriteLine("Новый массив:");
Console.WriteLine($"[ {string.Join(", ", array)} ]");

int count = 0;
for (int i = 0; i<array.Length; i++)
{
    if(array[i]%2==0)
    {
        count++;
    }
    
}
Console.WriteLine($"В полученном массиве количество положительных чисел = {count}");