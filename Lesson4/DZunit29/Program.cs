// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetRandomArray()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array [i] = Random.Shared.Next(0, 10);
}
return array;
}
int[] array = GetRandomArray();
Console.WriteLine($"[ {string.Join(", ", array)} ]");
