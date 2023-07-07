// Напишите программу вычисления функции Аккермана с
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите целое число M:");
int NumberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число N:");
int NumberN = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int FirstNumber, int LastNumber)
{
if(FirstNumber==0) return LastNumber+1;
else if (LastNumber==0 && FirstNumber>0) return AkkermanFunction(FirstNumber-1, 1);
else return AkkermanFunction(FirstNumber-1, AkkermanFunction(FirstNumber, LastNumber-1));
}
Console.Write(AkkermanFunction(NumberN, NumberM));

