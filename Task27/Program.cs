//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

void CalcAmount (int num_n) {

    // Описание переменных для функции
    int col = num_n.ToString().Length;
    int sum=0, num_x = 0;

    for(int i = 0; i < col; i++ ) {
    
        num_x = num_n % 10;
        sum=sum+num_x;
        num_n /= 10;
       }
Console.WriteLine("Получившееся число: "+sum);
}

// Ввод данных
int num_n = Prompt ("Введите число: ");

CalcAmount(num_n);