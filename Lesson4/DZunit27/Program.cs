//имает на вход число и выдаёт сумму цифр в числе./ Напишите программу, которая прин
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt()
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int SumNub(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = ReadInt();
Console.WriteLine($"Сумма всех чисел в {number} = {SumNub(number)}");