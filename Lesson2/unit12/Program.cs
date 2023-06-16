// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1 % num2;
Console.WriteLine (num3);
if (num3 !=0)
{
    Console.WriteLine (num3);
}
else
{
    Console.WriteLine("Второе число кратно первому");
}