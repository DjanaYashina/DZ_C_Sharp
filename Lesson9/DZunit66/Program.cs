// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Введите целое число M:");
int NumberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число N:");
int NumberN = Convert.ToInt32(Console.ReadLine());

int SumNumberMtoN(int FirstNumber, int LastNumber)
{
if(FirstNumber-1==LastNumber) return 0;
return FirstNumber + SumNumberMtoN(FirstNumber+1,LastNumber);
}
Console.Write(SumNumberMtoN(NumberM, NumberN));
