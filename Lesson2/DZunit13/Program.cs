// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine()); 
int result = num1;
int count = 0;
if (num1 < 100 )
{
    Console.WriteLine("Третей цифры нет");
}
else if (num1 > 100 && num1 < 999)
{
    Console.WriteLine(num1 % 10);
}
else
{
while (num1 > 999)
    {
    result = (num1 / 10);
    num1 = result;
    count++;
    }
Console.WriteLine (result % 10);
}