//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

//ПРОИЗВЕДЕНИЕ МАССИВОВ И ВЫВОД НА ЭКРАН
void ArrayComp(int[,] arr1,int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0)) Console.WriteLine("а я говорила, ничего не получится ↑");
    else
    {
        if (arr1.GetLength(0) == 1 || arr2.GetLength(0) == 1 ) Console.WriteLine("так тоже не получится, в матрицах больше одной строки");
        else 
        {
            int[,] compArr1_Arr2 = new int [arr1.GetLength(0), arr2.GetLength(1)];
            Console.WriteLine("Произведение:");
            for (int i =0; i < arr1.GetLength(0); i++)
            {
                for (int j =0; j < arr2.GetLength(1); j++)
                {
                    int scalar = 0;
                    for (int k =0; k < arr2.GetLength(1); k++)
                    {
                        scalar += arr1[i,k]*arr2[k,j];
                    }
                    compArr1_Arr2[i,j] = scalar;
                    Console.Write(compArr1_Arr2[i,j] + "  "); 
                }
                Console.WriteLine();
            }
        }
    }
    
}

int m1 = Input("m1 = ");
int n1= Input("n1 = ");
int[,] arr1 = new int[m1,n1];
ArrayRandomaizer(arr1);
WriteLNArray(arr1);
Console.WriteLine();
Console.WriteLine("n1 должно быть равно m2 сейчас. иначе ничё не получится, я серьезно");
int m2 = Input("m2 = ");
int n2 = Input("n2 = ");
int[,] arr2 = new int[m2,n2];
ArrayRandomaizer(arr2);
WriteLNArray(arr2);
Console.WriteLine();
ArrayComp(arr1,arr2);
