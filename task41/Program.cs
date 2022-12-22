//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
// что такое M... тогда с количеством можно определиться по ходу ввода. 
// нет в ТЗ - переложи выбор на юзера)
int count = 0;
int number = Input("вводите числа, пока не надоест. чтобы остановить безумие, введите '4242': ");
if (number!=4242) do 
{
    if (number > 0) count = count + 1;
    number = Input("еще число? ");
}
while (number != 4242);
Console.WriteLine($"чисел больше нуля: {count+1}");