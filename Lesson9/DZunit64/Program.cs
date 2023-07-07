// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите целое число N:");
int NumberN = Convert.ToInt32(Console.ReadLine());
int Count = 1;
void Nnumber(int number, int count)
{
if(count > number) return;
Nnumber(number, count+1);
Console.Write($"{count} ");
}
Nnumber(NumberN, Count);
