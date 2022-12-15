// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int[] arr = new int[8];
for (int i = 0; i < 8; i++) arr[i] = Input($"элемент {i+1}: ");
Console.Write($"[");
for (int i = 0; i < 7; i++) Console.Write($"{arr[i]}, ");
Console.WriteLine($"{arr[7]}]");