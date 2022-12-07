// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число и нажмите энтер: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100000 > 0 || number/10000 < 1) Console.WriteLine("Введи пятизначное число");
else
{
   int first = number/10000;
   int second = number%10000/1000;
   int third = number%1000/100;
   int fourth = number%100/10;
   int fifth = number%10;
   if (first == fifth && second == fourth) Console.WriteLine("полиндром");
   else Console.WriteLine("не полиндром");
}
