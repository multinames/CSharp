// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
        int[,] result = new int[m,n];
        
    for (int i=0; i<m; i++) 
    { 
        for(int j=0; j<n; j++) 
        {
        result[i,j] = new Random().Next(minValue, maxValue);
        }   
    }
    return result;
}

void PrintArraySingle(int[] arr)
{
    for(int i=0; i<arr.Length;i++) 
    {
           Console.Write($"{arr[i]} ");
    }
}

void PrintArray(int[,] inArray) {

Console.WriteLine($"Исходный массив: ");

for(int i=0; i < inArray.GetLength(0); i++) // Отвечает за столбцы 
    {
    for(int j = 0; j < inArray.GetLength(1); j++) // Отвечает за строки
        {
            Console.Write($"{inArray[i, j]} ");
        }
    Console.WriteLine();
    } 
}

void GetSortArray(int[,] inArray) 
{
  Console.WriteLine($"Отсортированный массив: ");
  
  
  for(int i=0; i < inArray.GetLength(0); i++) 
    
    {
        int[] res = new int[inArray.GetLength(1)];
         for(int j = 0; j < inArray.GetLength(1); j++) 
          
            {
               
               res[j] = inArray[i, j];
            }   
                Array.Sort(res);
                Array.Reverse(res);
                PrintArraySingle(res);
                Console.WriteLine();     
     }
     
}

// задаем размерность массива
int rows = 4;
int columns = 4;

// создание массива
int[,] array = GetArray(rows, columns, 0, 10);
int[,] inOutArray = new int[rows, columns];

PrintArray(array);
Console.WriteLine();
GetSortArray(array);
