// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return result;
}
Console.Write("Введите коордитнаты первой точки через Enter: ");
double xa = double.Parse(Console.ReadLine());
double ya = double.Parse(Console.ReadLine());
double za = double.Parse(Console.ReadLine());

Console.Write("Введите коордитнаты второй точки через Enter: ");
double xb = double.Parse(Console.ReadLine());
double yb = double.Parse(Console.ReadLine());
double zb = double.Parse(Console.ReadLine());


double distance = Distance3D(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(distance, 2, MidpointRounding.ToNegativeInfinity)}");

