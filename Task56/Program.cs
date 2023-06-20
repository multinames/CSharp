// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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

void GetValueArray(int[,] inArray) 
{
 
    List<int> m1 = new List<int>() ;
    
    for(int i=0; i < inArray.GetLength(0); i++) // Отвечает за столбцы 
    {
        
        int[] res = new int[inArray.GetLength(1)]; 
                   
        Console.Write($"Строка {i} -> ");  

         for(int j = 0; j < inArray.GetLength(1); j++) // Отвечает за строки
            {             
                res[j] = inArray[i, j];
                Console.Write($"{res[j]} ");
                
            } 
        int sum = res.Sum();
        Console.WriteLine($"- сумма элементов = {sum}");
         m1.Add(sum);

     }
        
     Console.WriteLine();
   //  Console.WriteLine($"Строка {Array.IndexOf(m1,m1.Min())} - содержит наименьшую сумму элементов ");
   Console.WriteLine($"Строка {m1.IndexOf(m1.Min())} - содержит наименьшую сумму элементов ");
}

// задаем размерность массива
int rows = 7;
int columns = 4;

// создание массива
int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
Console.WriteLine();
GetValueArray(array);



