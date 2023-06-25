// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray()
{
    int [] array = new int [4];
     for (int i = 0; i<array.Length; i++)
     {
        array [i] = Random.Shared.Next(-100, 100);
     }
     return array;
}
int[] array = GetRandomArray();
Console.WriteLine("Новый массив:");
Console.WriteLine($"[ {string.Join(", ", array)} ]");

int sum = 0;
for (int i = 0; i<array.Length; i++)
{
   if (i%2 != 0)
  {
        sum += array [i];  
  }
    
}
Console.WriteLine($"Сумма чисел на положительных индексах = {sum}");