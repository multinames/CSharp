// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt (string message) {
// Метод ввода чисел с клавиатуры
Console.Write(message);
string str = Console.ReadLine()!;
    // Проверка вводимых данных на число
    if ((int.TryParse(str, out int num)) == false) {
    Console.WriteLine("Это не число!");   
    }

    return num;
}

int FuncAkkerman (int m_num, int n_num)
// Вычисление функции Аккермана
{

  if (m_num == 0) return n_num + 1;
  else if (n_num == 0) return FuncAkkerman(m_num - 1, 1);
  else return FuncAkkerman(m_num - 1, FuncAkkerman(m_num, n_num - 1));

}

int m_num = Prompt("Введите число M ");
int n_num = Prompt("Введите число N ");

Console.WriteLine($"Функция Аккермана = {FuncAkkerman(m_num,n_num)}");