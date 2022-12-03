//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введи число (желательно трехзначное и больше): ");
double number = Convert.ToInt32(Console.ReadLine());
int figuresCount = number.ToString().Length;
if (figuresCount < 3)
{
    Console.WriteLine("Введи число длины, какой попросили");
}
else
{
double degree = Math.Pow(10, figuresCount-3); 
double result1 = number/degree%10;
int result = (int)result1;
Console.WriteLine(result);
}
//на самом деле я постоянно буду сдавать рандомные виды решений, потому что мне нравится исследовать больше, чем повторять
//пишите, если я увлекусь и превышу ради этого количество строк раза в 2, т.е. где будет точно неоправданно