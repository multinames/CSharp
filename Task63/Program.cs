// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int Prompt (string message) {
Console.Write(message);
string str = Console.ReadLine()!;
    // Проверка вводимых данных на число
    if ((int.TryParse(str, out int num)) == false) {
    Console.WriteLine("Это не число!");   
    }

    return num;
}

void NaturalNumber(int number, int count) 
{
    if (count<=number) {
    Console.WriteLine(count);
    NaturalNumber(number, count+1);
    }
}

int number = Prompt("Введите число: ");
// int i = 1;

NaturalNumber(number,1);