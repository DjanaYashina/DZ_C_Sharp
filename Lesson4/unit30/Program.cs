// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = 8;
int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array [i] = Random.Shared.Next(0, 2);
    Console.Write(array [i]);
}
