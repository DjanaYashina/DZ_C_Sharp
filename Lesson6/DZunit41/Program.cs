// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которые необходимо заполнить");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] NewArray(int number)
{
    int [] array = new int[number];
    for(int i=0; i<number; i++)
    {
      Console.WriteLine("Введите число");
      int num = Convert.ToInt32(Console.ReadLine());
      array[i] = num;

    if(num>0)
    {
        count++;
    }
    }
    return array;
}
Console.Write(string.Join(", ", NewArray(number)));
Console.Write($" из них больше нуля {count}");
