//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите Первое число и нажмите энтер: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число и нажмите энтер: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber == SecondNumber)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (FirstNumber > SecondNumber)
    {
        Console.WriteLine($"Первое число {FirstNumber} - больше, Второе число {SecondNumber} - меньше");
    }
    else
    {
         Console.WriteLine($"Первое число {FirstNumber} - меньше, Второе число {SecondNumber} - больше");
    }
}