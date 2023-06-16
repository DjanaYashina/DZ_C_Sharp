// Math.Pow(x, 2) возведение в степень
// Math.Sqrt(x)квадратный корень

// Напишите программу, которая на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первого числа по оси x:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первого числа по оси y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первого числа по оси z:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второго числа по оси x");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второго числа по оси y");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второго числа по оси z");
int z2 = Convert.ToInt32(Console.ReadLine());

double coordinatesX = Math.Pow(x1-x2, 2);
double coordinatesY = Math.Pow(y1-y2, 2);
double coordinatesZ = Math.Pow(z1-z2, 2);
double result = Math.Sqrt(coordinatesX + coordinatesY + coordinatesZ);
Console.WriteLine($"{result:f2}");