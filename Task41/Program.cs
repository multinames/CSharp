// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Prompt (string message, int size) {

int i = 0;
int sum = 0;

    while (i < size) 
    {
    Console.Write(message);

    string num = Console.ReadLine()!;

        if ((int.TryParse(num, out int num_n)) == false) 
        {
            Console.WriteLine("Это не число!");
            Environment.Exit(0);
        }
        else if (num_n >0)
        {
            sum++;
            
        }
        i++;  
    }
    Console.WriteLine("Чисел больше нуля: " + sum);    
}

Prompt ("Введите число: ", 5);
