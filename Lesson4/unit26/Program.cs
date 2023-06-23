// Напишите программу, которая принимает на вход число и выдаёт количество
// цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int Func (int number)
{
    int count = 0;
    while (number > 0)
    {
       number = number / 10;
       count++;
    }
    return count;
}

int number = ReadInt();
int count1 = Func (number);
Console.WriteLine($"Колличество цифр в числе = {count1}");