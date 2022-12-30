//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
}
int r = Input("Введите строку ");
int c = Input("Введите столбец ");
if (c < n && r < m) Console.WriteLine(arr[r,c]);
else Console.WriteLine("нет такого элемента");

