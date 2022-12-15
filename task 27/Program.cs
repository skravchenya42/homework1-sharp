// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
void Counting(int a)
{
    string str = a.ToString();
    int[] arr = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = a%10;
        a = a/10;
    }
    int sum = 0;
    for (int i = 0; i < str.Length; i++) sum = sum + arr[i];
    Console.WriteLine(sum);
}
int number = Input("число: ");
Counting(number);
