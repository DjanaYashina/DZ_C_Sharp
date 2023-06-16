// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine()); 
int amount = num1.ToString().Length;
if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(num1));
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
