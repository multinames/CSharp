// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

int Prompt (string message) {
Console.Write(message);
string str = Console.ReadLine()!;
    // Проверка вводимых данных на число
    if ((int.TryParse(str, out int num)) == false) {
    Console.WriteLine("Это не число!");   
    }

    return num;
}

int[,] GetArray(int m, int n, int minValue, int maxValue) 
// Заполнение массива
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

void SearchArray(int[,] inArray, int row, int column, int m, int n) 
// Поиск элмента по указанным значеним и проверка его наличия
{

int r1=0;
int c1=0;

if (row > m-1 || column > m-1 || row < 0 || column < 0) 
    {
        Console.Write($"[{row},{column}] нет такой позиции в массиве");
    }
else {

    for(int i=0; i < inArray.GetLength(0); i++) // Отвечает за столбцы 
    
        if (i == row) 
        {
            r1=i;
            for(int j = 0; j < inArray.GetLength(1); j++) // Отвечает за строки
                {
                // Console.Write($"{inArray[i, j]} ");
                if (j==column) 
                        {
                c1=j;
                }
            }
        }
        Console.Write($"[{row},{column}] позиция элемента {inArray[r1, c1]} ");
    }
}   

int row = Prompt("Укажите позицию строки элемента: ");
int column = Prompt("Укажите позицию столбца элемента: ");

// задаем размерность массива
int m = 4;
int n = 4;

// создание массива
int[,] array = GetArray(m, n, 0, 10);


PrintArray(array);

SearchArray(array, row, column, m, n);