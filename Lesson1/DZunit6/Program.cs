// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
string? numberOne = Console.ReadLine();
int nOne = Convert.ToInt32(numberOne); 

if (nOne % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}