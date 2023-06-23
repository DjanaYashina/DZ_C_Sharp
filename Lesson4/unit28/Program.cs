// Напишите программу, которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt()
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int Proizvedenie (int N)
{
    int result = 1;
    for (int i = 1; i<=N; i++)
    {
       result*=i;
    }
    return result;
}

int N = ReadInt();
int proizv = Proizvedenie (N);
Console.WriteLine($"Произведение чисел от 1 до {N} = {proizv}");