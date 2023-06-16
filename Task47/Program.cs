// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int Prompt (string message) {
Console.Write(message);
string num = Console.ReadLine()!;
    // Проверка вводимых данных на число
    if ((int.TryParse(num, out int num_n)) == false) {
    Console.WriteLine("Это не число!");   
    }
return num_n;
}

double[,] GetArray(int m, int n, int minValue, int maxValue) 
{
        double[,] result = new double[m,n];
        
    for (int i=0; i<m; i++) 
    {
        Random rand = new Random();
        
        for(int j=0; j<n; j++) 
        {
        result[i,j] = rand.NextDouble() + rand.Next(minValue, maxValue);
        }   
    }
    return result;
}

void PrintArray(double[,] inArray) {
for(int i=0; i < inArray.GetLength(0); i++) // Отвечает за столбцы 
    {
    for(int j = 0; j < inArray.GetLength(1); j++) // Отвечает за строки
        {
        Console.Write("{0:0.00} ", inArray[i, j]);
        // Console.Write("{0:0.00} ", arr[i] );
        }
    Console.WriteLine();
    } 
}

int rows = Prompt("Введите количество строк  массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

double[,] array = GetArray(rows, columns, -10, 10);

PrintArray(array);
