// See https://aka.ms/new-console-template for more information

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i< size; i++) 
        {
        res[i] = new Random().Next(minValue, maxValue+1);
        }
    return res;
}

void PrintArray(int[] arr)
{
    for(int i=0; i<arr.Length;i++) 
    {
           Console.Write($"{arr[i]} ");
    }


}

void FindSum(int[] arr) {
int possitiveSum = 0;
int negativeSum = 0;

foreach(int el in arr) {
    if (el >0 ) 
        {
            possitiveSum+=el;
        }

    else if (el <0 ) 
        {
            negativeSum+=el;
        }
}
Console.WriteLine();
Console.WriteLine($"Сумма положителдьныйх чисел равна: {possitiveSum}, сумма отрицателдьныйх числе равна: {negativeSum}");
}

int[] array2=GetArray(12,-9, 9);

PrintArray(array2);

FindSum(array2);

