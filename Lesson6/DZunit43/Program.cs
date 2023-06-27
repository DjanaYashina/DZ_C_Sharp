//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
double FindX()
{
    double x = (b1 - b2)/(k1 - k2);
    return x;
}
double FindY()
{
    double y = k2*((b1 - b2)/(k1 - k2))+ b2;
    return y;
}

double a =  FindX();
double b = FindY();
Console.Write($"{a},{b}");