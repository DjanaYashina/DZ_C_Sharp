// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine()); 
int num2 = num1 % 7;
int num3 = num1 % 23;
if ( num2 == 0 && num3 ==0)
{
   Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}


