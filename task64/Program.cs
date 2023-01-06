//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//ИНПУТ ДЛЯ ЦЕЛЫХ ЧИСЕЛ
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
//ПРИБАВЛЕНИЕ ЕДИНИЦЫ К INTEGER
void PlusOne(int N)
{
    if (N == 0) return;
    Console.Write($"{N} ");
    PlusOne(N-1);
}

int N = Input("натуральное N = ");
if (N <= 0) Console.Write("а ща ниче не вернется, это не натуральненько");
else PlusOne(N);

