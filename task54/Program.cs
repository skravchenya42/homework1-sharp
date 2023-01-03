//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

//ПЕРЕСТАНОВКИ (УБЫВАНИЕ)
void OrderByDESC(int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            for (int x=1; x<arr.GetLength(1); x++)
            {
                {
                    int max = arr[i,x-1];
                    if (max < arr[i,x]) 
                    {
                        arr[i,x-1] = arr[i,x];
                        arr[i,x] = max;
                        max = arr[i,x];
                    }
                }
            }
        }
    }
}

int m = Input("m = ");
int n = Input("n = ");
int[,] arr = new int[m,n];
ArrayRandomaizer(arr);
WriteLNArray(arr);
OrderByDESC(arr);
Console.WriteLine();
WriteLNArray(arr);