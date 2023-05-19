// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
string result = "";
Console.WriteLine("Все четные числа от 1 до "+numberA+":");
for (int i = 1 ; i < numberA+1; i++) {
    if ((i % 2) == 0) { 
    result = result + i + " ";
    }
}
Console.WriteLine(result);