// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю
// цифру этого числа.
// 456 -> 6

// int number = ReadInt("Введите трехзначное число: ");
// int amount = number.ToString().Length;

// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(InCenter(number));
// }
// // ФУНКЦИИ------------------------------------------------------------------------------------------------------

// // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Функция вывода цифры стоящей в середине трехзначногно числа.
// int InCenter(int a)
// {
    
//     int result = ((a / 10) % 10);
//     return result;
// }

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
 if (b < 3)
    {
 Console.Write("Третьей цифры нет: ");
    }
 else
    {
 int c = 1;
 for (int i = b; i > 3; i--)
        {
 c = c * 10;
        }

 result = (a / c) % 10;
    }
return result;
}