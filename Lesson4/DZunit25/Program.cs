// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt()
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumFrom1ToA(int a, int b)
{
    int sum = a;
    for(int i=1; i<b; i++)
    {
        sum = sum*a;
    }
    return sum;
}
int number1 = ReadInt();
int number2 = ReadInt();
int  stepen = SumFrom1ToA(number1, number2);
Console.WriteLine($"Возведение числа {number1} в степень {number2} = {stepen}");