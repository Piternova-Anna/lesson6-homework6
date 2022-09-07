// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k2");
double k2 = double.Parse(Console.ReadLine());

if ((b1 == b2) && (k1 == k2))
{
    Console.WriteLine("данные прямые НЕ пересекаются");
}
else
{
    double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;

Console.WriteLine("данные прямые пересекаются в точке с координатами"+"("+ x +";"+ y +")");
}

