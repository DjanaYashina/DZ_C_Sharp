// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int namber = Random.Shared.Next(100,1000);
Console.WriteLine(namber);

int firstDigit = (namber / 100) % 10; //берем певую цифру числа
int lastDigit = namber % 10; //берем последнюю цифру этого числа

Console.WriteLine(firstDigit * 10 + lastDigit);//чтобы получить двузначное число необходимо первое число 