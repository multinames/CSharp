// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

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

void ToExpo(int num_a, int num_b) {
    // Определение переменных для цикла
    int i=1;
    int result=num_a;

    //Цикл возведение в степень
    while (i != num_b) {
        result=result*num_a;
        i++;
    }

    Console.WriteLine("Полученное число: " + result);
}

// Ввод данных
int num_a = Prompt ("Введите число A: ");
int num_b = Prompt ("Введите число B: ");

ToExpo(num_a,num_b);