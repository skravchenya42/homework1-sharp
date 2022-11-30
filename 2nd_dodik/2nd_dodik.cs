//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите Первое число и нажмите энтер: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число и нажмите энтер: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Третье число и нажмите энтер: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = FirstNumber;
if (SecondNumber > max)
{
    max = SecondNumber;
    if (ThirdNumber > max)
    {
        max = ThirdNumber;
    }
}
else
    if (ThirdNumber > max)
    {
        max = ThirdNumber;
    }
Console.WriteLine($"max = {max}");