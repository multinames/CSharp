// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами

int Prompt (string message) {
Console.Write(message);
string num = Console.ReadLine()!;
    // Проверка вводимых данных на число
    if ((int.TryParse(num, out int num_n)) == false) {
    Console.WriteLine("Это не число!");   
    }
return num_n;
}

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

int rows = Prompt("Введите количество строк  массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);