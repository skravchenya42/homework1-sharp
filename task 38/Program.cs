// See https://aka.ms/new-console-template for more information
int RandomValue()
{
    Random rnd = new Random();
    return rnd.Next(42,4242);
}
double[] arr = new double[RandomValue()];
for (int i = 0; i < arr.Length; i++) arr[i] = Convert.ToDouble(RandomValue());
double min = arr[0];
double max = arr[0];
 for (int i=0; i<arr.Length; i++)
 {
    if (arr[i]<min)
    {
        min = arr[i];
    }
    if (arr[i]>max)
    {
        max = arr[i];
    }
 }
Console.WriteLine(max - min);
