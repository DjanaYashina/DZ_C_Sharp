// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите целое число M:");
int NumberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число N:");
int NumberN = Convert.ToInt32(Console.ReadLine());

void NumberMtoN(int LastNumber, int FirstNumber)
{
if(LastNumber<=FirstNumber-1) return;
NumberMtoN(LastNumber-1,FirstNumber);
Console.Write($"{LastNumber} ");
}
NumberMtoN(NumberN, NumberM);
