// напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// я про циклы недопоняла, цикл пользователь должен остановить? вряд ли, пусть так будет, если мы про функции:
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
void Counting(int a, int b)
{
    int degree = 1;
    for (int i = 0; i < b; i++)
    {
        degree = a * degree;
    }
    Console.WriteLine(degree);
}
int A = Input("A: ");
int B = Input("B: ");
Counting(A, B);
