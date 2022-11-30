// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число и нажмите энтер: ");
int NowYouSee = 0;
int number = Convert.ToInt32(Console.ReadLine());
do
{
    if (number%2==0)
    {
        NowYouSee = number;
        Console.Write($"{NowYouSee} ");
    }
    number = number-1;

}
while (number !=0);
