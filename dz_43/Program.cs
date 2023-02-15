/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите координату первой точки, k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки, b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки, k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки, b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Koord(b2,b1,k2,k1);

void Koord(double b2, double b1, double k2, double k1)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    if (k1 == k2 && b1 == b2) Console.WriteLine("Совпадают");
    else if (k1==k2) Console.WriteLine("Параллельны");
    else Console.WriteLine($"Пересекутья в точке с координатами Х: {y};{x}");
}
