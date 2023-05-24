// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число дня недели");

string str = Console.ReadLine();

// Проверка на число
if ((int.TryParse(str, out int numDay)) == false) {
  Console.WriteLine("Это не число!");
    return;
}

// Проверка на день недели
if (numDay <1 || numDay >7  ) {

    Console.WriteLine("Введите корректный день недели [1-7]");
}

else if (numDay == 6 || numDay == 7 ) {
    Console.WriteLine("День выходной");
}
else {
    Console.WriteLine("День не выходной");
}