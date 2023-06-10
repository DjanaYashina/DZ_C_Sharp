// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.

Console.WriteLine("Введите число 1:");
string? numberOne = Console.ReadLine();
int nOne = Convert.ToInt32(numberOne); 

Console.WriteLine("Введите число 2:");
string? numberTwo = Console.ReadLine();
int nTwo = Convert.ToInt32(numberTwo);

Console.WriteLine("Введите число 3:");
string? numberThree = Console.ReadLine();
int nThree = Convert.ToInt32(numberThree);

int Max = nOne;
    if (nTwo > Max)
    {
    Max = nTwo;
    }
    if (nThree > Max)
    {
    Max = nThree;
    }
Console.Write("Max = ");
Console.WriteLine(Max);
