// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    Random rand = new Random();
    for (int i = 0; i< size; i++) 
        {
             res[i]=rand.NextDouble() + rand.Next(minValue, maxValue+1);
        }
    return res;
}

void PrintArray(double[] arr)
{
    Console.Write("Массив: ");
    for(int i=0; i<arr.Length;i++) 
    {
           Console.Write("{0:0.00} ", arr[i] );
    }


}

void FindDiffNum(double[] arr) {


Console.WriteLine();
Console.WriteLine("Минимальное число массива: "+ "{0:0.00}", arr.Min());
Console.WriteLine("Максимальное число массива: "+ "{0:0.00}", arr.Max());
Console.WriteLine("Разность: "+ "{0:0.00}", (arr.Max()-arr.Min()));
}

double[] arr=GetArray(5, 1, 5);

PrintArray(arr);

FindDiffNum(arr);


