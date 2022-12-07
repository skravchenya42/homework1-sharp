// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("число:");
double number = Convert.ToDouble(Console.ReadLine());
for (double i = 1; i <number+1; i++)
{
    Console.Write("\t"+Math.Pow(i,3));
}
