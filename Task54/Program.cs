// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();

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

void PrintArray(int[,] inArray) {
for(int i=0; i < inArray.GetLength(0); i++) // Отвечает за столбцы 
    {
    for(int j = 0; j < inArray.GetLength(1); j++) // Отвечает за строки
        {
            Console.Write($"{inArray[i, j]} ");

        }
    Console.WriteLine();
    } 
}

void GetValueArray(int[,] inArray) 
{
  // Console.Write($"Среднее арифметическое каждого столбца: ");
  
  for(int i=0; i < inArray.GetLength(0); i++) 
    
    {
    double sum =0;
     for(int j = 0; j < inArray.GetLength(1); j++) 
            {
               sum+=inArray[i, j];
            }
    // double res = Math.Round( sum / inArray.GetLength(1), 2);
         
     Console.Write($"{sum} ");
     }
     
}

// задаем размерность массива
int rows = 4;
int columns = 4;

// создание массива
int[,] array = GetArray(rows, columns, 0, 10);


PrintArray(array);
GetValueArray(array);