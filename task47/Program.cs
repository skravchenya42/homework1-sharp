// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Input("m = ");
int n = Input("n = ");
double[,] arr = new double[m,n];
double Random()
{
    Random r = new Random();
    return r.NextDouble()*10;
}
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
    {
        arr[i,j] = Math.Round(Random(),1);
        Console.Write(arr[i,j] + "  ");
    
    }
    Console.WriteLine();
}