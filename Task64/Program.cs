// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

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
    
    if (count>=1) {
    Console.Write($"{count} ");
    NaturalNumber(number, count-1);
    }
}

int number = Prompt("Введите число: ");

NaturalNumber(number,number);
