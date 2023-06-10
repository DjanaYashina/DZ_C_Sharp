// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все
// чётные числа от 1 до N.
Console.WriteLine("Введите число:");
string? number = Console.ReadLine();
int N = Convert.ToInt32(number); 

for (int i = 2; i<= N; i = i+2 ) 
{
  Console.Write(i);
}