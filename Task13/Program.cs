// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите целое число");

string str = Console.ReadLine();

// Проверка на число
if ((int.TryParse(str, out int num)) == false) {
  Console.WriteLine("Это не число!");
    return;
}

// Определение числа по модулю
int nnn=Math.Abs(Convert.ToInt32(str));

// Вывод третьей цифры
if (nnn.ToString().Length < 3) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    Console.WriteLine("Третья цифра в " + nnn + " равна "+ nnn.ToString()[2]);
}
