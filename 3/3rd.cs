// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число и нажмите энтер: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
{
    Console.WriteLine("я загуглила, 0 тоже четное число");   
}
else
{
if (number%2 == 0)
{
    Console.WriteLine($"число {number} - четное");
}
else
{
   Console.WriteLine($"число {number} - нечетное");   
}
}


