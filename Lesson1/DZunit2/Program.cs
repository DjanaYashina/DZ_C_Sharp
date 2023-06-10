// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число
// большее, а какое меньшее.
Console.WriteLine("Введите число 1:");
string? numberOne = Console.ReadLine();
int nOne = Convert.ToInt32(numberOne); 

Console.WriteLine("Введите число 2:");
string? numberTwo = Console.ReadLine();
int nTwo = Convert.ToInt32(numberTwo);
int Max = 0;
int Min = 0;

if (nOne > nTwo)
{
    Max = nOne;
    Console.Write("Max = ");
    Console.WriteLine(Max);
    Min = nTwo;
    Console.Write("Min = ");
    Console.Write(Min);
}
else
{
    Max = nTwo;
    Console.Write("Max = ");
    Console.WriteLine(Max);
    Min = nOne;
    Console.Write("Min = ");
    Console.Write(Min);
}
