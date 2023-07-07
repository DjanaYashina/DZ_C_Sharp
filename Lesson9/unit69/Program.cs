// Напишите программу, которая на вход принимает два
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите целое число M:");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число N:");
int Stepen = Convert.ToInt32(Console.ReadLine());

int VozvedenieVStepen(int osnovanie, int mnozhetel)
{
if(mnozhetel==0) return 1;
return VozvedenieVStepen(osnovanie, mnozhetel-1) * osnovanie;
}
Console.Write(VozvedenieVStepen(Number,Stepen));