// Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] GetRandomArray()
{
    int [] array = new int [12];
     for (int i = 0; i<array.Length; i++)
     {
        array [i] = Random.Shared.Next(-9, 10);
     }
     return array;
}

int[] array = GetRandomArray();
Console.WriteLine("Изначальный массив:");
Console.WriteLine($"[ {string.Join(", ", array)} ]"); // string.Join(", ", myArray) слепляет элементы массива и выводит их  в строку ("," - разделитель, значение)

for (int i = 0; i<array.Length; i++)
{
    array[i] = -array[i]; // это вместо умножение на -1
}

Console.WriteLine("Измененный массив:");
Console.WriteLine($"[ {string.Join(", ", array)} ]"); // string.Join(", ", myArray) слепляет элементы массива и выводит их  в строку ("," - разделитель, значение)