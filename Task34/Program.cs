// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
// Заполнение массива случайными числами
{
    int[] res = new int[size];
    
    for (int i = 0; i< size; i++) 
        {
        res[i] = new Random().Next(minValue, maxValue+1);
        }
    return res;
}

void CheckEvNum(int[] arr) 
// Вывод количество чётных чисел в массиве
  {
    int i=0;
    foreach(int el in arr) {
        if ((el % 2) == 0) {
        i+=1 ; }
  }
    Console.Write($"Количество четных чисел равно {i}");
}
int[] arr = GetArray(5,100,999);
CheckEvNum(arr);