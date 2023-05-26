// Задача 22:

int Prompt (string message) {
Console.Write(message);
string num = Console.ReadLine()!;

    if ((int.TryParse(num, out int num_n)) == false) {
    Console.WriteLine("Это не число!");   
    }

return num_n;
}

void PrintDegreTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 2) + " ");
    }
}

int num = Prompt ("Введите число N: ");

// Определение числа по модулю
int number = Math.Abs(num);

PrintDegreTable(number);





