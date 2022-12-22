//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
void Intersection (int k1, int b1, int k2, int b2)
{
if(k1 == k2) Console.WriteLine("параллельные, получается");
else
    {
    int x = (b1-b2)/(k2-k1);
    int y = (k2*b1-k1*b2)/(k2-k1);
    Console.WriteLine($"корды: {x}, {y}");
    }
}
int k1 = Input("k1: ");
int b1 = Input("b1: ");
int k2 = Input("k2: ");
int b2 = Input("b2: ");
Intersection(k1,b1,k2,b2);
