﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все
// чётные числа от 1 до N.
Console.WriteLine("Введите число:");
string? number = Console.ReadLine();
int N = Convert.ToInt32(number); 
int i = 1;
while (i <= N) 
{
  if (i % 2 == 0)
  Console.Write(i + ", ");
  i++;

}