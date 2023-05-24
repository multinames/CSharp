// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");

string str = Console.ReadLine();

// Проверка на число
if ((int.TryParse(str, out int num)) == false) {
  Console.WriteLine("Это не число!");
    return;
}

// Определение числа по модулю
num = Math.Abs(Convert.ToInt32(str));

// Проверка числа на разрядность   
if (num.ToString().Length != 3) {
    Console.WriteLine("Число не трехзначное");
    return;
}  

// Вывод второй цифры
Console.WriteLine("Вторая цифра в " + num + " равна "+ num.ToString()[1]);


