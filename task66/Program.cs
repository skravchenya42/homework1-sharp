//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// ИНПУТ ДЛЯ ЦЕЛЫХ ЧИСЕЛ
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}

// УРАВНИТЕЛЬ ДВУХ ЧИСЕЛ (ЗАОДНО СЧИТАЕТ СУММУ)
int SumDiff(int M,int N,int result)
{

    if (M == N) return result;
    if (M<N)
    {
        M++;
        result = result+M;
        return SumDiff(M,N,result);
    }
    else
    {
        N++;
        result = result+N;
        return SumDiff(M,N,result);
    }

}

int M = Input("натуральное M = ");
int N = Input("натуральное N = ");
Console.Write(SumDiff(M,N,0));

