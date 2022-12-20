// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int RandomValue()
{
    Random rnd = new Random();
    return rnd.Next(100,999);
}
int[] arr = new int[42];
for (int i = 0; i < arr.Length; i++) arr[i] = RandomValue();
int count = 0;
for (int i = 0; i < arr.Length; i++) if (arr[i]%2 == 0) count = count +1;
Console.WriteLine(count);
    





