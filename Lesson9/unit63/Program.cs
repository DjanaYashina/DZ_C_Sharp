// Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Введите целое число N:");
int value = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {value} -> ");
// for(int i=1; i<=value; i++)
// {
//     Console.Write($"{i}, ");
// }
void Nnumber(int number)
{
if(number<=0) return;
Nnumber(number-1);
Console.Write($"{number} ");
}
Nnumber(value);
