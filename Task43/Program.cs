// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

int Prompt (string message) {
Console.Write(message);
string num = Console.ReadLine()!;
// Проверка вводимых данных на число
    if ((int.TryParse(num, out int num_n)) == false) {
    Console.WriteLine("Это не число!");   
    }
    // Определение числа по модулю
    int num_check=Math.Abs(Convert.ToInt32(num_n));
return num_check;
}

void FindDot(double b1, double k1, double b2, double k2)
// метод нахождения точки пересечения
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Точка пересечения двух прямых: ({x},{y})");
}

// Задаем коориданты
double b1= Prompt ("Введите значение b1: ");
double k1= Prompt ("Введите значение k1: ");
double b2= Prompt ("Введите значение k2: ");
double k2= Prompt ("Введите значение k2: ");

FindDot(b1, k1, b2, k2);