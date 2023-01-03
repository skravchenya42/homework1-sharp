//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//ИНПУТ ДЛЯ ЦЕЛЫХ ЧИСЕЛ
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}

//ЗАПОЛНЕНИЕ МАССИВА РАНДОМАЙЗЕРОМ
void ArrayRandomaizer(int[,] arr)
{
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,42);
        }
    }
}

//ПЕЧАТАЕМ МАССИВ
void WriteLNArray(int[,] arr)
{
for (int i = 0; i<arr.GetLength(0); i++)
{
    for (int j = 0; j<arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j] + "  ");
    }
Console.WriteLine();
}
}

//МАССИВ С СУММАМИ ПОСТРОЧНО
int RowSum(int[,] arr)
{
    int sum = 0;
    int minI = 1; //я решила, что строка это индекс +1
    int tempSum = 0;
    for (int j = 0; j<arr.GetLength(1); j++) 
    {
        tempSum += arr[0,j];
    }
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++) 
        {
            sum += arr[i,j];
        }
        if (tempSum >= sum)
        {
        minI = i+1; // это потому что я там так решила ↑
        tempSum = sum;
        }
        sum = 0;
    }
    return minI;
}

int m = Input("m = ");
int n = Input("n = ");
int[,] arr = new int[m,n];
ArrayRandomaizer(arr);
WriteLNArray(arr);
Console.WriteLine();
Console.WriteLine(RowSum(arr));
