// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");

string str = Console.ReadLine();

// Проверка на число
if ((int.TryParse(str, out int num)) == false) {
  Console.WriteLine("Это не число!");
    return;
}

// Определение числа по модулю
int nnn=Math.Abs(Convert.ToInt32(str));

// Проверка числа на разрядность   
if (nnn.ToString().Length != 3) {
    Console.WriteLine("Число не трехзначное");
    return;
}  

// Вывод второй цифры
Console.WriteLine("Вторая цифра в " + nnn + " равна "+ nnn.ToString()[1]);


