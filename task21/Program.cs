// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введи координаты первой точки:");
double X1 = Convert.ToDouble(Console.ReadLine());
double Y1 = Convert.ToDouble(Console.ReadLine());
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи координаты второй точки:");
double X2 = Convert.ToDouble(Console.ReadLine());
double Y2 = Convert.ToDouble(Console.ReadLine());
double Z2 = Convert.ToDouble(Console.ReadLine());
if (X1==X2 && Y1==Y2 && Z1==Z2) Console.WriteLine("Расстояние: 0");
else 
{
    Console.WriteLine($"Расстояние: ");
    Console.WriteLine(Math.Sqrt((Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2))));
}