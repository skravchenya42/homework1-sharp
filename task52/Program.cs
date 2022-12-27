// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Input("m = ");
int n = Input("n = ");
int[,] arr = new int[m,n];
int Random()
{
    Random r = new Random();
    return r.Next(0,42);
}
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
    {
        arr[i,j] = Random(); 
        Console.Write(arr[i,j] + "  ");
    }
Console.WriteLine();
//avg = sum/n;
}
//Console.WriteLine(avg);
int sum = 0;
for (int j = 0; j<n; j++)
{
    for (int i = 0; i<m; i++)
    {
        sum = sum + arr[i,j];
    }
Console.Write(sum/m + " ");
}
