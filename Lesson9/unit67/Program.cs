// Напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
if(number<=0)return 0;
return number%10 + SumNumber(number/10);
}
Console.Write(SumNumber(FirstNumber));