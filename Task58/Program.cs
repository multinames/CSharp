// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int m, int n, int minValue, int maxValue) 
// Метод заполнения массива случайными числами
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

void PrintArray(int[,] inArray, string message) {

Console.WriteLine($"{message}: ");

for(int i=0; i < inArray.GetLength(0); i++) // Отвечает за столбцы 
    {
    for(int j = 0; j < inArray.GetLength(1); j++) // Отвечает за строки
        {
            Console.Write($"{inArray[i, j]} ");
        }
    Console.WriteLine();
    } 
}


int [,] MultiMatrix(int[,] a_matrix, int[,] b_matrix, int[,] c_matrix) 
// метод выичисления двух матриц
{
     for (int i = 0; i < a_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < b_matrix.GetLength(1); j++)
        {
            for (int k = 0; k < b_matrix.GetLength(0); k++)
            {
            c_matrix[i, j] += a_matrix[i, k]*b_matrix[k, j];  
            }
        }
    }
    return c_matrix;
 }


// задаем размерность массива
int rows = 2;
int columns = 2;

// инициализация матриц
int[,] a_matrix = GetArray(rows, columns, 0, 10);
int[,] b_matrix = GetArray(rows, columns, 0, 10);
int[,] c_matrix = new int [rows, columns];

PrintArray(a_matrix, "Первая матрица");
PrintArray(b_matrix, "Вторая матрица");

c_matrix = MultiMatrix(a_matrix, b_matrix, c_matrix);

 PrintArray(c_matrix,"Результат умножения двух матриц: ");