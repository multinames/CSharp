// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Prompt (string message) {
// Метод ввода числе с клавиатуры
Console.Write(message);
string str = Console.ReadLine()!;
    // Проверка вводимых данных на число
    if ((int.TryParse(str, out int num)) == false) {
    Console.WriteLine("Это не число!");   
    }

    return num;
}

void NaturalNumbers(int m_num, int n_num, int sum)
// Вычислдение суммы натуральных элементов в промежутке от M до N
{
   Console.WriteLine((m_num+n_num)*(n_num-m_num+1)/2);
}

int m_num = Prompt("Введите число M ");
int n_num = Prompt("Введите число N ");
NaturalNumbers(m_num, n_num,0);