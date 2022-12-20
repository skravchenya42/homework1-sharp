// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int RandomValue()
{
    Random rnd = new Random();
    return rnd.Next(42,4242);
}
int[] arr = new int[42];
//зачем заполнять полностью, если в итоге сложить надо только нечетные позиции?
for (int i = 1; i < arr.Length; i+=2) arr[i] = RandomValue();
int sum = 0;
for (int i = 0; i < arr.Length; i++) sum = sum + arr[i]; 
Console.WriteLine(sum);
