//cЗадача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i< size; i++) 
        {
        res[i] = new Random().Next(minValue, maxValue+1);
        }
    return res;
}
void SumOddNum(int[] arr) 
  {
    int sumOdd=0;

    for (int i=0; i< arr.Length;i++) {
            if ((i % 2) != 0) {
                // Console.Write($"Число на нечетной позиции {arr[i]}\n");
                sumOdd=sumOdd+arr[i];
        }     
    }
    Console.Write($"Сумма элементов на нечётных позициях {sumOdd}");
  }
int[] arr = GetArray(6,-9,9);
SumOddNum(arr);