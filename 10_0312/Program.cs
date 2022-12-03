//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число и нажмите энтер: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 || number < 100)
{
    Console.WriteLine("Введи число длины, какой просили :/");
}
else
{
    int SecondAndThird = (number%100)/10;
    Console.WriteLine($"вот вторая цифра: {number%100/10}");
}
