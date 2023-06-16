// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ●
// A (3,6); B (2,1) -> 5,09
// ●
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первого числа по оси x:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первого числа по оси y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второго числа по оси x");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второго числа по оси y");
int y2 = Convert.ToInt32(Console.ReadLine());


double coordinatesX = Math.Pow(x1-x2, 2);
double coordinatesY = Math.Pow(y1-y2, 2);
double result = Math.Sqrt(coordinatesX + coordinatesY);
Console.WriteLine($"{result:f2}");