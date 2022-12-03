//15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number == 0)
{
    Console.WriteLine("Прочитай, какое число просили ввести и введи нормально");
}
else
if (number == 6 || number == 7)
{
    Console.WriteLine("вых, норм");
}
else
{
    Console.WriteLine("бегом на работку!");
}
